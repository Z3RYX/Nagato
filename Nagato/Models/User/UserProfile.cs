using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class UserProfile
    {
        /// <summary>
        /// Text content on user's profile
        /// </summary>
        [JsonProperty("content")]
        public string? Content { get; set; }

        /// <summary>
        /// Background image on user's profile
        /// </summary>
        [JsonProperty("background")]
        public File? Background { get; set; }
    }
}
