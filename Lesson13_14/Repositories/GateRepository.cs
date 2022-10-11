using Lesson13_14.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Repositories
{
    internal class GateRepository
    {
        public List<Gate> ListOfGates = new List<Gate>();
        public GateRepository()
        {
            ListOfGates.Add(new Gate(1, new List<string> {"Junior", "Middle", "Senior"}));
            ListOfGates.Add(new Gate(2, new List<string> {"Middle", "Senior"}));
            ListOfGates.Add(new Gate(3, new List<string> {"Senior"}));
            ListOfGates.Add(new Gate(4, new List<string> {"Junior"}));
        }
        public Gate Retrieve(int gateId)
        {
            var talpykla = ListOfGates[0];
            for (int i = 0; i < ListOfGates.Count; i++)
            {
                if (ListOfGates[i].GateId == gateId)
                {
                    talpykla = ListOfGates[i];
                }
            }
            return talpykla;
        }
    }
}
