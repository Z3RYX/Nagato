using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class GenericServiceConfiguration
    {
        /// <summary>
        /// Whether the service is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// URL pointing to the service
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }
    }
}
