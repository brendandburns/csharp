namespace k8s.WebSockets
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Net.Http.Headers;
    using System.Net.WebSockets;
    using System.Threading;
    using System.Threading.Tasks;

    public class WebSocketCall
    {
        const string V4_STREAM_PROTOCOL = "v4.channel.k8s.io";
        const string V3_STREAM_PROTOCOL = "v3.channel.k8s.io";
        const string V2_STREAM_PROTOCOL = "v2.channel.k8s.io";
        const string V1_STREAM_PROTOCOL = "channel.k8s.io";
        const string STREAM_PROTOCOL_HEADER = "X-Stream-Protocol-Version";
        const string SPDY_3_1 = "SPDY/3.1";



        public interface SocketListener
        {
            void Open(string protocol, ClientWebSocket socket);

            void BytesMessage(int channel, Stream stream);

            void TextMessage(int channel, Stream stream);

            void Close();
        }


    public static async Task StreamAsync(string path, string method, Dictionary<string, string[]> queryParams, IKubernetes client, SocketListener listener, CancellationToken token) {
        var socket = new ClientWebSocket();
        string allProtocols = V4_STREAM_PROTOCOL + "," + V3_STREAM_PROTOCOL + "," + V2_STREAM_PROTOCOL + "," + V1_STREAM_PROTOCOL;
        socket.Options.SetRequestHeader(STREAM_PROTOCOL_HEADER, allProtocols);
        socket.Options.SetRequestHeader("Connection", "Upgrade");
        socket.Options.SetRequestHeader("Upgrade", SPDY_3_1);

        string scheme = client.BaseUri.Scheme == "http" ? "ws" : "wss";
        var builder = new UriBuilder(client.BaseUri.ToString());
        builder.Scheme = scheme;
        builder.Path = path;
        if (queryParams != null && queryParams.Count > 0) {
            builder.Query = "?";
            foreach(var key in queryParams.Keys) {
                var parameters = queryParams[key];
                foreach(var param in parameters) {
                    builder.Query = builder.Query + key + "=" + param + "&";
                }
            }
        }

        await socket.ConnectAsync(builder.Uri, token);

        listener.Open("protocol", socket);

        var stream = new MemoryStream();
        var buffer = new byte[4096];
        var channel = -1;

        while (socket.State != WebSocketState.Closed) {
            var seg = new ArraySegment<byte>(buffer);
            var result = await socket.ReceiveAsync(seg, token);
            if (result.MessageType == WebSocketMessageType.Close) {
                listener.Close();
                await socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "Closing as requested.", token);
            }
            if (channel == -1) {
                channel = buffer[0];
                stream.Write(buffer, 1, result.Count - 1);
            } else {
                stream.Write(buffer, 0, result.Count);
            }
            if (result.EndOfMessage) {
                stream.Position = 0;
                if (result.MessageType == WebSocketMessageType.Binary) {
                    listener.BytesMessage(channel, stream);
                } else if (result.MessageType == WebSocketMessageType.Text) {
                    listener.TextMessage(channel, stream);
                }
            }
        }
    }

/*
    public static class Listener implements WebSocketListener {
        private SocketListener listener;

        public Listener(SocketListener listener) {
            this.listener = listener;
        }

        public void onOpen(final WebSocket webSocket, Response response) {
            String protocol = response.header(STREAM_PROTOCOL_HEADER, "missing");
            listener.open(protocol, webSocket);
        }

        public void onMessage(ResponseBody body) throws IOException {
            if (body.contentType() == TEXT) {
                listener.bytesMessage(body.byteStream());
            } else if (body.contentType() == BINARY) {
                listener.textMessage(body.charStream());
            }
            body.close();
        }

        public void onPong(Buffer payload) {
        }

        public void onClose(int code, String reason) {
            listener.close();
        }

        public void onFailure(IOException e, Response res) {
            e.printStackTrace();
            listener.close();
        }
    }
    */
}
}