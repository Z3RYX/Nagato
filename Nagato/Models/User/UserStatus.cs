using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class UserStatus
    {
        /// <summary>
        /// Custom text status
        /// </summary>
        [JsonProperty("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Presence status
        /// </summary>
        [JsonProperty("presence")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Presence PresenceStatus { get; set; }
    }
}
