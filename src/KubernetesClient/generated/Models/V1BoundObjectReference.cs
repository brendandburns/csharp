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
    /// BoundObjectReference is a reference to an object that a token is bound
    /// to.
    /// </summary>
    public partial class V1BoundObjectReference
    {
        /// <summary>
        /// Initializes a new instance of the V1BoundObjectReference class.
        /// </summary>
        public V1BoundObjectReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1BoundObjectReference class.
        /// </summary>
        /// <param name="apiVersion">API version of the referent.</param>
        /// <param name="kind">Kind of the referent. Valid kinds are 'Pod' and
        /// 'Secret'.</param>
        /// <param name="name">Name of the referent.</param>
        /// <param name="uid">UID of the referent.</param>
        public V1BoundObjectReference(string apiVersion = default(string), string kind = default(string), string name = default(string), string uid = default(string))
        {
            ApiVersion = apiVersion;
            Kind = kind;
            Name = name;
            Uid = uid;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets API version of the referent.
        /// </summary>
        [JsonProperty(PropertyName = "apiVersion")]
        public string ApiVersion { get; set; }

        /// <summary>
        /// Gets or sets kind of the referent. Valid kinds are 'Pod' and
        /// 'Secret'.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        public string Kind { get; set; }

        /// <summary>
        /// Gets or sets name of the referent.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets UID of the referent.
        /// </summary>
        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

    }
}