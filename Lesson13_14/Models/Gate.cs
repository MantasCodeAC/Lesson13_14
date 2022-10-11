using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class Gate
    {
        public int GateId { get; set; }
        public List<string> WhoCanPass { get; set; }
        public Gate (int gateId, List<string> whoCanPass)
        {
            GateId = gateId;
            WhoCanPass = whoCanPass;
        }
    }
}
