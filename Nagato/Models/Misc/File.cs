using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class File
    {
        /// <summary>
        /// Unique ID (not ULID)
        /// </summary>
        [JsonProperty("_id")]
        public string? ID { get; set; }

        /// <summary>
        /// Tag / bucket this file was uploaded to
        /// </summary>
        [JsonProperty("tag")]
        public string? Tag { get; set; }

        /// <summary>
        /// Original filename
        /// </summary>
        [JsonProperty("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// Metadata associated with a file
        /// </summary>
        [JsonProperty("metadata")]
        public Metadata? Metadata { get; set; }

        /// <summary>
        /// Raw content type of this file
        /// </summary>
        [JsonProperty("content_type")]
        public string? ContentType { get; set; }

        /// <summary>
        /// Size of this file (in bytes)
        /// </summary>
        [JsonProperty("size")]
        public int Size { get; set; }

        /// <summary>
        /// Whether this file was deleted
        /// </summary>
        [JsonProperty("deleted")]
        public bool? IsDeleted { get; set; }

        /// <summary>
        /// Whether this file was reported
        /// </summary>
        [JsonProperty("reported")]
        public bool? IsReported { get; set; }

        /// <summary>
        /// ID of the message this file is associated with
        /// </summary>
        [JsonProperty("message_id")]
        public ID? MessageID { get; set; }

        /// <summary>
        /// ID of the user this file is associated with
        /// </summary>
        [JsonProperty("user_id")]
        public ID? UserID { get; set; }

        /// <summary>
        /// ID of the server this file is associated with
        /// </summary>
        [JsonProperty("server_id")]
        public ID? ServerID { get; set; }

        /// <summary>
        /// ID of the object this file is associated with
        /// </summary>
        [JsonProperty("object_id")]
        public ID? ObjectID { get; set; }
    }
}
