using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nagato.Models
{
    public class ID
    {
        public string RawID { get; }
        public ID(string id)
        {
            RawID = id;
            //TODO: Decode ULID to get timestamp from ID
        }

        public DateTime Timestamp { get; }
    }
}
