// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// IngressBackend describes all endpoints for a given service and port.
    /// </summary>
    public partial class Extensionsv1beta1IngressBackend
    {
        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1IngressBackend
        /// class.
        /// </summary>
        public Extensionsv1beta1IngressBackend()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Extensionsv1beta1IngressBackend
        /// class.
        /// </summary>
        /// <param name="resource">Resource is an ObjectRef to another
        /// Kubernetes resource in the namespace of the Ingress object. If
        /// resource is specified, serviceName and servicePort must not be
        /// specified.</param>
        /// <param name="serviceName">Specifies the name of the referenced
        /// service.</param>
        /// <param name="servicePort">Specifies the port of the referenced
        /// service.</param>
        public Extensionsv1beta1IngressBackend(V1TypedLocalObjectReference resource = default(V1TypedLocalObjectReference), string serviceName = default(string), string servicePort = default(string))
        {
            Resource = resource;
            ServiceName = serviceName;
            ServicePort = servicePort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets resource is an ObjectRef to another Kubernetes
        /// resource in the namespace of the Ingress object. If resource is
        /// specified, serviceName and servicePort must not be specified.
        /// </summary>
        [JsonProperty(PropertyName = "resource")]
        public V1TypedLocalObjectReference Resource { get; set; }

        /// <summary>
        /// Gets or sets specifies the name of the referenced service.
        /// </summary>
        [JsonProperty(PropertyName = "serviceName")]
        public string ServiceName { get; set; }

        /// <summary>
        /// Gets or sets specifies the port of the referenced service.
        /// </summary>
        [JsonProperty(PropertyName = "servicePort")]
        public string ServicePort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Resource != null)
            {
                Resource.Validate();
            }
        }
    }
}
