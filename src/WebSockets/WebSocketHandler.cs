namespace k8s.WebSockets {
    using System.Collections.Generic;
    using System.IO;
    using System.Net.WebSockets;

    public class WebSocketHandler : WebSocketCall.SocketListener {
        public Dictionary<int, Stream> OutputStreams { get; set; }
        private ClientWebSocket socket;

        public WebSocketHandler() {
            OutputStreams = new Dictionary<int, Stream>();
        }

        public void Open(string protocol, ClientWebSocket socket) {
            this.socket = socket;
        }

        public void BytesMessage(int channel, Stream stream) {
            if (!OutputStreams.ContainsKey(channel)) {
                // Log an error here?
                return;
            }
            stream.CopyTo(OutputStreams[channel]);
        }

        public void TextMessage(int channel, Stream stream) {
            if (!OutputStreams.ContainsKey(channel)) {
                // Log an error here?
                return;
            }
            stream.CopyTo(OutputStreams[channel]);
        }

        public void Close() {
            // nothing to do.
        }
    }
}