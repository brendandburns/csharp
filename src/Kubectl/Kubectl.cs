/*
Copyright 2020 The Kubernetes Authors.
Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at
http://www.apache.org/licenses/LICENSE-2.0
Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

using k8s;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace KubectlDotNet
{
    public class Kubectl
    {
        private KubernetesClientConfiguration config;

        public Kubectl(KubernetesClientConfiguration config)
        {
            this.config = config;
        }

        public KubectlGet<T> Get<T>()
        where T : IKubernetesObject
        {
            return new KubectlGet<T>(config);
        }

        public class KubectlNameNamespaceBase<T>
        where T : class
        {
            protected KubernetesClientConfiguration Config { get; }

            private string _name;
            private string _namespace;

            public KubectlNameNamespaceBase(KubernetesClientConfiguration config)
            {
                this.Config = config;
            }

            protected string Name() => _name;

            public T Name(string name)
            {
                this._name = name;
                return Unsafe.As<T>(this);
            }

            protected string Namespace() => this._namespace;

            public T Namespace(string ns)
            {
                this._namespace = ns;
                return Unsafe.As<T>(this);
            }
        }
    }

    public interface IExecutable<T>
    where T : IKubernetesObject
    {
        public Task<T> Execute();
    }
}
