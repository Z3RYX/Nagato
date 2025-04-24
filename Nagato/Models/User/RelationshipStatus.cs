using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public enum RelationshipStatus
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "User")]
        User,
        [EnumMember(Value = "Friend")]
        Friend,
        [EnumMember(Value = "Outgoing")]
        Outgoing,
        [EnumMember(Value = "Incoming")]
        Incoming,
        [EnumMember(Value = "Blocked")]
        Blocked,
        [EnumMember(Value = "BlockedOther")]
        BlockedOther
    }
}
