using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class User
    {
        /// <summary>
        /// Unique ID
        /// </summary>
        [JsonProperty("_id")]
        public ID? ID { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [JsonProperty("username")]
        public string? Username { get; set; }

        /// <summary>
        /// Discriminator
        /// </summary>
        [JsonProperty("discriminator")]
        public string? Discriminator { get; set; }

        /// <summary>
        /// Display name
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Avatar
        /// </summary>
        [JsonProperty("avatar")]
        public File? Avatar { get; set; }

        /// <summary>
        /// Relationships with other users
        /// </summary>
        [JsonProperty("relations")]
        public List<Relationship>? Relations { get; set; }

        /// <summary>
        /// Bitfield of user badges
        /// </summary>
        [JsonProperty("badges")]
        public UserBadges? Badges { get; set; }

        /// <summary>
        /// User's active status
        /// </summary>
        [JsonProperty("status")]
        public UserStatus? Status { get; set; }

        /// <summary>
        /// Enum of user flags
        /// </summary>
        [JsonProperty("flags")]
        public UserFlags? Flags { get; set; }

        /// <summary>
        /// Whether this user is privileged
        /// </summary>
        [JsonProperty("privileged")]
        public bool? IsPrivileged { get; set; }

        /// <summary>
        /// Bot information for if the user is a bot
        /// </summary>
        [JsonProperty("bot")]
        public Bot? Bot { get; set; }

        /// <summary>
        /// User's relationship with another user (or themselves)
        /// </summary>
        [JsonProperty("relationship")]
        [JsonConverter(typeof(StringEnumConverter))]
        public RelationshipStatus? Relationship { get; set; }

        /// <summary>
        /// Whether this user is currently online
        /// </summary>
        [JsonProperty("online")]
        public bool? IsOnline { get; set; }
    }
}
