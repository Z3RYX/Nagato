using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class Relationship
    {
        /// <summary>
        /// Other user's ID
        /// </summary>
        [JsonProperty("_id")]
        public ID? UserID { get; set; }

        /// <summary>
        /// User's relationship with another user (or themselves)
        /// </summary>
        [JsonProperty("status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipStatus Status { get; set; }
    }
}
