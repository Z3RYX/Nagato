using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public enum Presence
    {
        [EnumMember(Value = "Online")]
        None,
        [EnumMember(Value = "Idle")]
        Idle,
        [EnumMember(Value = "Focus")]
        Focus,
        [EnumMember(Value = "Busy")]
        Busy,
        [EnumMember(Value = "Invisible")]
        Invisible
    }
}
