using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class HCaptchaConfiguration
    {
        /// <summary>
        /// Whether captcha is enabled
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }

        /// <summary>
        /// Client key used for solving captcha
        /// </summary>
        [JsonProperty("key")]
        public string? Key { get; set; }
    }
}
