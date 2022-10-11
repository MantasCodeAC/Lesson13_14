using Lesson13_14.Models;
using Lesson13_14.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Repositories
{
    internal class EventRepository
    {
        public List<List<Event>> RepositoryListOfEvents = new List<List<Event>>();
        public EventRepository()
        {
            GateRepository gateRepository = new GateRepository();
            PersonRepository personRepository = new PersonRepository();
            TryToPass report = new TryToPass(gateRepository, personRepository);
            RepositoryListOfEvents = report.CheckIf();
        }

    }
}
