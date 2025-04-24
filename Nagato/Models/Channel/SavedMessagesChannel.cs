using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class SavedMessagesChannel : Channel
    {
        [JsonProperty("user")]
        public ID? UserID { get; set; }
    }
}
