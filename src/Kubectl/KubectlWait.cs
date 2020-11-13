using k8s;
using k8s.Models;
using Microsoft.Rest.Serialization;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace KubectlDotNet
{
    public class KubectlWait<T> : Kubectl.KubectlNameNamespaceBase<KubectlWait<T>>, IExecutable<T>
    where T : IKubernetesObject
    {
        private string condition;
        private TimeSpan timeout;

        public KubectlWait(KubernetesClientConfiguration config)
        : base(config)
        {
        }

        public KubectlWait<T> Timeout(TimeSpan timeout)
        {
            this.timeout = timeout;
            return this;
        }

        public KubectlWait<T> Condition(string condition)
        {
            this.condition = condition;
            return this;
        }

        public async Task<T> Execute()
        {
            return await Wait.WaitFor(this.Load, this.Condition, timeout).ConfigureAwait(false);
        }

        private bool Condition(T obj)
        {
            return HasCondition(obj, this.GetType().GetGenericArguments()[0], this.condition);
        }

        private bool HasCondition(T obj, Type type, string condition)
        {
            dynamic dobj = (dynamic)obj;
            if (type.Equals(typeof(V1Pod)))
            {
                return PodHasCondition((V1Pod)dobj, condition);
            }
            else if (type.Equals(typeof(V1Node)))
            {
                return NodeHasCondition((V1Node)dobj, condition);
            }

            throw new InvalidOperationException("Unsupported type: " + type);
        }

        private bool NodeHasCondition(V1Node node, string condition)
        {
            foreach (var c in node.Status.Conditions)
            {
                if (c.Type.Equals(condition) && bool.Parse(c.Status))
                {
                    return true;
                }
            }

            return false;
        }

        private bool PodHasCondition(V1Pod pod, string condition)
        {
            foreach (var c in pod.Status.Conditions)
            {
                if (c.Type.Equals(condition) && bool.Parse(c.Status))
                {
                    return true;
                }
            }

            return false;
        }

        protected async Task<T> Load()
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
