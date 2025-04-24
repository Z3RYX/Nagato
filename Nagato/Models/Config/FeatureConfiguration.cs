using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class FeatureConfiguration
    {
        /// <summary>
        /// hCaptcha configuration
        /// </summary>
        [JsonProperty("captcha")]
        public HCaptchaConfiguration CaptchaConfig { get; set; }

        /// <summary>
        /// Whether email verification is enabled
        /// </summary>
        [JsonProperty("email")]
        public bool HasEmailVerification { get; set; }

        /// <summary>
        /// Whether this server is invite only
        /// </summary>
        [JsonProperty("invite_only")]
        public bool IsInviteOnly { get; set; }

        /// <summary>
        /// File server service configuration
        /// </summary>
        [JsonProperty("autumn")]
        public GenericServiceConfiguration AutumnConfig { get; set; }

        /// <summary>
        /// Proxy service configuration
        /// </summary>
        [JsonProperty("january")]
        public GenericServiceConfiguration JanuaryConfig { get; set; }

        /// <summary>
        /// Voice server configuration
        /// </summary>
        [JsonProperty("voso")]
        public VoiceServerConfiguration VosoConfig { get; set; }
    }
}
