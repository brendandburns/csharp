// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// PriorityLevelConfigurationStatus represents the current state of a
    /// "request-priority".
    /// </summary>
    public partial class V1alpha1PriorityLevelConfigurationStatus
    {
        /// <summary>
        /// Initializes a new instance of the
        /// V1alpha1PriorityLevelConfigurationStatus class.
        /// </summary>
        public V1alpha1PriorityLevelConfigurationStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// V1alpha1PriorityLevelConfigurationStatus class.
        /// </summary>
        /// <param name="conditions">`conditions` is the current state of
        /// "request-priority".</param>
        public V1alpha1PriorityLevelConfigurationStatus(IList<V1alpha1PriorityLevelConfigurationCondition> conditions = default(IList<V1alpha1PriorityLevelConfigurationCondition>))
        {
            Conditions = conditions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets `conditions` is the current state of
        /// "request-priority".
        /// </summary>
        [JsonProperty(PropertyName = "conditions")]
        public IList<V1alpha1PriorityLevelConfigurationCondition> Conditions { get; set; }

    }
}