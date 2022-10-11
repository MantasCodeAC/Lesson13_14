using Lesson13_14.Repositories;
using Lesson13_14.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

ReportGenerator ataskaita = new ReportGenerator();
var ataskaitaSuccess = ataskaita.FinalSuccessReportGenerator();
System.IO.File.WriteAllText("ataskaita.txt", ataskaitaSuccess);
var ataskaitaAll = ataskaita.FinalAllEventsReportGenerator();
System.IO.File.WriteAllText("ataskaitaFull.txt", ataskaitaAll);
WorkTimeCalculator laikoAtaskaita = new WorkTimeCalculator();
var dayWorkHours = laikoAtaskaita.WorkTime(ataskaita);
System.IO.File.WriteAllText("ataskaitaLaiko.txt", dayWorkHours);









