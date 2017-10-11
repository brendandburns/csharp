namespace k8s {
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;
    using k8s.WebSockets;

    public class Attach {
        public IKubernetes Client { get; }

        public Attach(IKubernetes client) {
            this.Client = client;
        }

        private static string MakePath(string ns, string name, string container, bool stdin, bool tty) {
          return "/api/v1/namespaces/" +
            ns +
            "/pods/" +
            name +
            "/attach?" +
            "stdin=" + stdin +
            "&tty=" + tty +
            (container != null ? "&container=" + container : "");
        }

        public async Task AttachAsync(string namespce, string name, bool stdin, Stream stdout, Stream stderr) {
            await AttachAsync(namespce, name, null, stdin, false, stdout, stderr);
        }

        public async Task AttachAsync(string namespce, string name, string container, bool stdin, bool tty, Stream stdout, Stream stderr) {
           string path = Attach.MakePath(namespce, name, container, stdin, tty);

            WebSocketHandler handler = new WebSocketHandler();
            handler.OutputStreams[0] = stdout;
            handler.OutputStreams[1] = stderr;
            await WebSocketCall.StreamAsync(path, "GET", null, Client, handler, CancellationToken.None);
        }
    }
}
