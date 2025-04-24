using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class DataEditUser
    {
        /// <summary>
        /// New display name
        /// </summary>
        [JsonProperty("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Attachment ID for avatar
        /// </summary>
        [JsonProperty("avatar")]
        public string? AvatarAttachmentID { get; set; }

        /// <summary>
        /// User's active status
        /// </summary>
        [JsonProperty("status")]
        public UserStatus? Status { get; set; }

        /// <summary>
        /// New user profile data
        /// </summary>
        [JsonProperty("profile")]
        public UserProfile? Profile { get; set; }

        /// <summary>
        /// Bitfield of user badges
        /// </summary>
        [JsonProperty("badges")]
        public UserBadges? Badges { get; set; }

        /// <summary>
        /// Enum of user flags
        /// </summary>
        [JsonProperty("flags")]
        public UserFlags? Flags { get; set; }

        /// <summary>
        /// Fields to remove from user object
        /// </summary>
        [JsonProperty("remove")]
        [JsonConverter(typeof(StringEnumConverter))]
        public List<UserFields>? ToRemove { get; set; }
    }
}
