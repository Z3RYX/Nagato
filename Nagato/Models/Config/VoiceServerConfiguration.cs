using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class VoiceServerConfiguration
    {
        /// <summary>
        /// Whether voice is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// URL opinting to the voice API
        /// </summary>
        [JsonProperty("url")]
        public string? Url { get; set; }

        /// <summary>
        /// URL pointing to the voice WebSocket server
        /// </summary>
        [JsonProperty("ws")]
        public string? WebSocketUrl { get; set; }
    }
}
