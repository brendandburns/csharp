namespace attach
{
    using System;
    using System.IO;
    using k8s;

    class Attach
    {
        static void Main(string[] args)
        {
            var k8sClientConfig = new KubernetesClientConfiguration();
            IKubernetes client = new Kubernetes(k8sClientConfig);
            Attach att = new Attach(client);

            var o = new MemoryStream();
            var e = new MemoryStream();

            var task = att.AttachAsync("default", "nginx-4217019353-39slh", false, o, e);
            task.Wait();
        }
    }
}
