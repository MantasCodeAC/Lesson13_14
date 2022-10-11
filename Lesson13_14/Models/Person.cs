using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14
{
    internal class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
        public int AmountOfEvents { get; set; }

        public Person (int personId, string name, string role, int amountOfEvents)
        {
            PersonId = personId;
            Name = name;
            Role = role;
            AmountOfEvents = amountOfEvents;
        }
    }
}
