using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class Metadata
    {
        /// <summary>
        /// Type of file
        /// </summary>
        [JsonProperty("type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public MetadataType Type { get; set; }

        /// <summary>
        /// Width of an Image or Video
        /// </summary>
        [JsonProperty("width")]
        public uint Width { get; set; }

        /// <summary>
        /// Height of an Image or Video
        /// </summary>
        [JsonProperty("height")]
        public uint Height { get; set; }
    }

    public enum MetadataType
    {
        [EnumMember(Value = "File")]
        File,
        [EnumMember(Value = "Text")]
        Text,
        [EnumMember(Value = "Image")]
        Image,
        [EnumMember(Value = "Video")]
        Video,
        [EnumMember(Value = "Audio")]
        Audio
    }
}
