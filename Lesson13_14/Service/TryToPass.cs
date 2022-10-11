using Lesson13_14.Models;
using Lesson13_14.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Service
{
    internal class TryToPass
    {
        public GateRepository _gateRepository { get; set; }
        public PersonRepository _personRepository { get; set; }
        public TryToPass(GateRepository gateRepository, PersonRepository personRepository)
        {
            _gateRepository = gateRepository;
            _personRepository = personRepository;
        }
        public List<List<Event>> CheckIf()
        {
            List<List<Event>> FinalList = new List<List<Event>>();           
            double eventoId=0;
            foreach (var human in _personRepository.ListOfPersons)
            {
                Random morningTime = new Random();
                DateTime laikas = DateTime.Today.AddMinutes(morningTime.Next(390, 511));
                List<Event> ListOfEvents = new List<Event>();
                int numberOfSucessfulPasses = 0;
                var vartaiVisiems = _gateRepository.Retrieve(1);
                for (int i = 0; i < human.AmountOfEvents; i++)
                {
                    Random randomGate = new Random();
                    Random randomBreakMinutes = new Random();
                    Event ivykis = new Event();                  
                    var vartaiBandomieji = _gateRepository.Retrieve(randomGate.Next(1, 5));
                    if (vartaiBandomieji.WhoCanPass.Contains(human.Role))
                    {
                        ivykis.EventId = eventoId;
                        ivykis.IfPass = true;
                        ivykis.WhoPass = human;
                        ivykis.WherePass = vartaiBandomieji;
                        laikas = laikas.AddMinutes(randomBreakMinutes.Next(30,61));
                        ivykis.WhenPass = laikas;
                        numberOfSucessfulPasses = numberOfSucessfulPasses + 1;
                    }
                    else
                    {
                        ivykis.EventId = eventoId;
                        ivykis.IfPass = false;
                        ivykis.WhoPass = human;
                        ivykis.WherePass = vartaiBandomieji;
                        laikas = laikas.AddMinutes(randomBreakMinutes.Next(30, 61));
                        ivykis.WhenPass = laikas;
                    }
                    eventoId = eventoId + 1;
                    ListOfEvents.Add(ivykis);
                }
                if (numberOfSucessfulPasses % 2 == 1)
                {
                    Event ivykis = new Event();
                    ivykis.EventId = eventoId;
                    eventoId = eventoId+1;                  
                    ivykis.IfPass = true;
                    ivykis.WhoPass = human;
                    ivykis.WherePass = vartaiVisiems;
                    ivykis.WhenPass = DateTime.Today.AddHours(18);
                    ListOfEvents.Add(ivykis);
                }
                FinalList.Add(ListOfEvents);
            }
            return FinalList;
        }
    }
}
