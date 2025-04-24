using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public enum UserFlags
    {
        Suspended = 1,
        Deleted = 2,
        Banned = 4,
        Spam = 8
    }
}
