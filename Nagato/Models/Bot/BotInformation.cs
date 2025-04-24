using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class BotInformation
    {
        /// <summary>
        /// ID of the owner of this bot
        /// </summary>
        [JsonProperty("owner")]
        public ID? OwnerID { get; set; }
    }
}
