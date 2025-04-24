using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public enum UserFields
    {
        [EnumMember(Value = "Avatar")]
        Avatar,
        [EnumMember(Value = "StatusText")]
        StatusText,
        [EnumMember(Value = "StatusPresence")]
        StatusPresence,
        [EnumMember(Value = "ProfileContent")]
        ProfileContent,
        [EnumMember(Value = "ProfileBackground")]
        ProfileBackground,
        [EnumMember(Value = "DisplayName")]
        DisplayName,
        [EnumMember(Value = "Internal")]
        Internal
    }
}
