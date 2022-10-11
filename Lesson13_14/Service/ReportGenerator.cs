using Lesson13_14.Models;
using Lesson13_14.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Service
{
    internal class ReportGenerator
    {
        EventRepository eventRepository = new EventRepository();
        public List<List<Event>> ReportoGeneravimas()
        {
            List<List<Event>> FinalListOfPassEvents = new List<List<Event>>();
            foreach(var personList in eventRepository.RepositoryListOfEvents)
            {
                List<Event> ListOfPassEvents = new List<Event>();
                foreach (var personEvent in personList)
                {
                    if (personEvent.IfPass)
                    {
                        ListOfPassEvents.Add(personEvent);
                    }
                }
                FinalListOfPassEvents.Add(ListOfPassEvents);
            }
            return FinalListOfPassEvents;
        }
        public string FinalSuccessReportGenerator()
        {
            string finalReportGenerated = "SĖKMINGŲ PRAĖJIMŲ PRO VARTUS ATASKAITA\n\n";
            foreach (var report in ReportoGeneravimas())
            {
                int c = 0;
                string comeOrReturn = null;
                report.Sort(delegate (Event x, Event y)
                {
                    return x.WhenPass.CompareTo(y.WhenPass);
                });
                foreach (var personReport in report)
                {
                    if (c % 2 == 0)
                    {
                        comeOrReturn = "parėjo pro vartus ";
                    }
                    else
                    {
                        comeOrReturn = "išėjo pro vartus ";
                    }
                    c++;
                    finalReportGenerated = finalReportGenerated + ($"Įvykio ID: {personReport.EventId} \n" +
                        $"Žmogaus vardas: {personReport.WhoPass.Name} \n" +
                        $"Žmogaus rolė: {personReport.WhoPass.Role} \n" +
                        $"Vartų ID kuriuos praėjo: {personReport.WherePass.GateId}\n" +
                        $"Laikas, kuriuo {comeOrReturn} {personReport.WhenPass}\n" +
                        $"------------------------------------\n");                        
                }
            }
            return finalReportGenerated;  
        }
        public string FinalAllEventsReportGenerator()
        {
            List<List<Event>> FinalListOfEvents = new List<List<Event>>();
            string finalReportAllGenerated = "VISŲ PRAĖJIMŲ PRO VARTUS ATASKAITA\n\n";
            foreach (var personList in eventRepository.RepositoryListOfEvents)
            {
                personList.Sort(delegate (Event x, Event y)
                {
                    return x.WhenPass.CompareTo(y.WhenPass);
                });
                
                foreach (var personEvent in personList)
                {
                    finalReportAllGenerated = finalReportAllGenerated + ($"Įvykio ID: {personEvent.EventId} \n" +
                        $"Žmogaus vardas: {personEvent.WhoPass.Name} \n" +
                        $"Žmogaus rolė: {personEvent.WhoPass.Role} \n" +
                        $"Vartų ID kuriuos bandė praeiti: {personEvent.WherePass.GateId}\n" +
                        $"Laikas, kuriuo buvo bandymas praeiti {personEvent.WhenPass}\n" +
                        $"Ar pavyko praeiti:  {personEvent.IfPass} \n" +
                        $"------------------------------------\n");
                }              
            }
            return finalReportAllGenerated;
        }
    }
}
