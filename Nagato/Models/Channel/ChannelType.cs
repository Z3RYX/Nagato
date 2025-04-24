using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public enum ChannelType
    {
        [EnumMember(Value = "SavedMessages")]
        SavedMessages,
        [EnumMember(Value = "DirectMessage")]
        DirectMessage,
        [EnumMember(Value = "Group")]
        Group,
        [EnumMember(Value = "TextChannel")]
        TextChannel,
        [EnumMember(Value = "VoiceChannel")]
        VoiceChannel
    }
}
