using System;
using System.Threading.Tasks;
using k8s;
using k8s.Models;
using KubectlDotNet;

namespace exec
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            var config = KubernetesClientConfiguration.BuildConfigFromConfigFile();
            var cli = new Kubectl(config);

            var ns = args[0];
            var name = args[1];

            // Get Pod
            var pod = await cli.Get<V1Pod>().Namespace(ns).Name(name).Execute().ConfigureAwait(false);
            Console.WriteLine(pod.Metadata.Name);

            // List Pods
            var pods = await cli.Get<V1PodList>().Namespace(ns).Execute().ConfigureAwait(false);
            foreach (var aPod in pods.Items)
            {
                Console.WriteLine(aPod.Metadata.Name);
            }
        }
    }
}
