using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class Error
    {
        /// <summary>
        /// Where this error occured
        /// </summary>
        [JsonProperty("location")]
        public string? Location { get; set; }
    }
}
