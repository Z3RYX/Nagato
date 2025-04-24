using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class ServerConfiguration
    {
        /// <summary>
        /// Revolt API Version
        /// </summary>
        [JsonProperty("revolt")]
        public string? RevoltAPIVersion { get; set; }

        /// <summary>
        /// Features enabled on this Revolt node
        /// </summary>
        [JsonProperty("features")]
        public FeatureConfiguration? Features { get; set; }

        /// <summary>
        /// WebSocket URL
        /// </summary>
        [JsonProperty("ws")]
        public string? WebSocketUrl { get; set; }

        /// <summary>
        /// URL pointing to the client serving this node
        /// </summary>
        [JsonProperty("app")]
        public string? AppUrl { get; set; }

        /// <summary>
        /// Web Push VAPID public key
        /// </summary>
        [JsonProperty("vapid")]
        public string? VapidKey { get; set; }

        /// <summary>
        /// Build Information
        /// </summary>
        [JsonProperty("build")]
        public BuildInformation BuildInfo { get; set; }
    }
}
