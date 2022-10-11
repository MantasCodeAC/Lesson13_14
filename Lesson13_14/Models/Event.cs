using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Models
{
    internal class Event
    {
        public double EventId { get; set; }
        public bool IfPass { get; set; }
        public Person WhoPass { get; set; }
        public Gate WherePass { get; set; }
        public DateTime WhenPass { get; set; }
        //public Event (int eventId, bool ifPass, Person whoPass, Gate wherePass, DateTime whenPass)
        //{
        //    EventId = eventId;
        //    IfPass = ifPass;
        //    WhoPass = whoPass;
        //    WherePass = wherePass;
        //    WhenPass = whenPass;
        //}

    }
}
