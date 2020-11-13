using k8s;
using System;
using Microsoft.Rest.Serialization;
using System.Threading.Tasks;

namespace KubectlDotNet
{
    public class KubectlGet<T> : Kubectl.KubectlNameNamespaceBase<KubectlWait<T>>, IExecutable<T>
    where T : IKubernetesObject
    {
        public KubectlGet(KubernetesClientConfiguration config)
        : base(config)
        {
        }

        public async Task<T> Execute()
        {
            var t = this.GetType().GetGenericArguments()[0];
            var gvk = TypeMapper.Instance().GetGroupVersionKind(t);
            var client = new GenericClient(Config, gvk.Group, gvk.Version, gvk.Plural);
            if (string.IsNullOrEmpty(this.Name()))
            {
                return (string.IsNullOrEmpty(this.Namespace()) ?
                    await client.ListAsync<T>().ConfigureAwait(false) :
                    await client.ListNamespacedAsync<T>(this.Namespace()).ConfigureAwait(false));
            }

            return
                (string.IsNullOrEmpty(this.Namespace()) ?
                    await client.ReadAsync<T>(this.Name()).ConfigureAwait(false) :
                    await client.ReadNamespacedAsync<T>(this.Namespace(), this.Name()).ConfigureAwait(false));
        }
    }
}
