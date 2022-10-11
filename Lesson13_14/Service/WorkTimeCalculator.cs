using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13_14.Service
{
    internal class WorkTimeCalculator
    {
        public string WorkTime(ReportGenerator reportTaker)
        {
            string reportOfWorkTime = "Darbuotojų išdirbtas dienos laikas:\n\n";
            var listOfItems = reportTaker.ReportoGeneravimas();
            int count = 0;
            foreach (var item in listOfItems)
            {
                TimeSpan minCount=new TimeSpan();
                int i= 0;              
                foreach(var eventx in item)
                {
                    if (i % 2 == 0)
                    {
                        minCount = minCount + item[i + 1].WhenPass.Subtract(item[i].WhenPass);                     
                    }                   
                    i++;
                }
                reportOfWorkTime = reportOfWorkTime + $"DARBUOTOJAS {item[0].WhoPass.Name}\n IŠDIRBTAS DIENOS DARBO LAIKAS YRA {minCount.Hours}VAL. IR {minCount.Minutes}MIN.\n";
                count = count +1;
            }
            return reportOfWorkTime;
        }
    }
}
