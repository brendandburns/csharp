// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ExternalMetricStatus indicates the current value of a global metric not
    /// associated with any Kubernetes object.
    /// </summary>
    public partial class V2beta1ExternalMetricStatus
    {
        /// <summary>
        /// Initializes a new instance of the V2beta1ExternalMetricStatus
        /// class.
        /// </summary>
        public V2beta1ExternalMetricStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2beta1ExternalMetricStatus
        /// class.
        /// </summary>
        /// <param name="currentValue">currentValue is the current value of the
        /// metric (as a quantity)</param>
        /// <param name="metricName">metricName is the name of a metric used
        /// for autoscaling in metric system.</param>
        /// <param name="currentAverageValue">currentAverageValue is the
        /// current value of metric averaged over autoscaled pods.</param>
        /// <param name="metricSelector">metricSelector is used to identify a
        /// specific time series within a given metric.</param>
        public V2beta1ExternalMetricStatus(string currentValue, string metricName, string currentAverageValue = default(string), V1LabelSelector metricSelector = default(V1LabelSelector))
        {
            CurrentAverageValue = currentAverageValue;
            CurrentValue = currentValue;
            MetricName = metricName;
            MetricSelector = metricSelector;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets currentAverageValue is the current value of metric
        /// averaged over autoscaled pods.
        /// </summary>
        [JsonProperty(PropertyName = "currentAverageValue")]
        public string CurrentAverageValue { get; set; }

        /// <summary>
        /// Gets or sets currentValue is the current value of the metric (as a
        /// quantity)
        /// </summary>
        [JsonProperty(PropertyName = "currentValue")]
        public string CurrentValue { get; set; }

        /// <summary>
        /// Gets or sets metricName is the name of a metric used for
        /// autoscaling in metric system.
        /// </summary>
        [JsonProperty(PropertyName = "metricName")]
        public string MetricName { get; set; }

        /// <summary>
        /// Gets or sets metricSelector is used to identify a specific time
        /// series within a given metric.
        /// </summary>
        [JsonProperty(PropertyName = "metricSelector")]
        public V1LabelSelector MetricSelector { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (CurrentValue == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CurrentValue");
            }
            if (MetricName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MetricName");
            }
        }
    }
}
