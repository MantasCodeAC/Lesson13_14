using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Repositories
{
    internal class PersonRepository
    {
        public List<Person> ListOfPersons = new List<Person>();
        Random rnd = new Random();
        public PersonRepository()
        {
            ListOfPersons.Add(new Person(100, "Adelė", "Junior", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(101, "Benas", "Middle", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(102, "Cecilija", "Senior", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(103, "Dovydas", "Junior", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(104, "Eugenijus", "Middle", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(105, "Feliksas", "Senior", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(106, "Gintaras", "Junior", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(107, "Henrikas", "Middle", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(108, "Igmantė", "Senior", rnd.Next(4, 13)));
            ListOfPersons.Add(new Person(109, "Jomantas", "Junior", rnd.Next(4, 13)));
        }
    }
}
