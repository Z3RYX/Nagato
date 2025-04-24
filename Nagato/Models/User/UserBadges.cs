using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public enum UserBadges
    {
        Developer = 1,
        Translator = 2,
        Supporter = 4,
        ResponsibleDisclosure = 8,
        Founder = 16,
        PlatformModeration = 32,
        ActiveSupporter = 64,
        Paw = 128,
        EarlyAdopter = 256,
        ReservedRelevantJokeBadge1 = 512,
        ReservedRelevantJokeBadge2 = 1_024
    }
}
