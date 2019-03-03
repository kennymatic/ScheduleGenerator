using System;
using System.Collections.Generic;
using System.Linq;
using Util;

namespace ScheduleStrategies
{
    public class ScheduleGenerator
    {

        public IEnumerable<string> Generate(IEnumerable<Payee> payees) 
        { 
            var year = DateTime.Now.Year;
            var month = DateTime.Now.Month + 1; 
            var nextDate = new DateTime(year, month, 1); 
            var weekly = new WeeklyStrategy(nextDate); 
            var biWeekly = new BiWeeklyStrategy(nextDate); 
            var monthly = new MonthlyStrategy(nextDate); 
            var scheduleItems = new List<ScheduleItem>(); 
            foreach (var payee in payees) 
            {
                IEnumerable<DateTime> schedule = null; 
                IIntervalStrategy strategy = null; 
                switch (payee.GetFrequencyType())
                {
                    case FrequencyType.Weekly:
                        strategy = weekly; 
                        break; 
                    case FrequencyType.Monthly:
                        strategy = monthly; 
                        break; 
                    case FrequencyType.BiWeekly:
                        strategy = biWeekly;
                        break;
                }
                schedule = strategy.GenerateSchedule(payee.LastDate);
                scheduleItems.AddRange(ItemsFromSchedule(payee.Name, schedule)); 
            }
            return scheduleItems.OrderBy(i=>i.DateTime).Select(i=>i.ToString());
        }

        ScheduleItem[] ItemsFromSchedule(string payeeName, IEnumerable<DateTime> schedule)
        {
            var items = new List<ScheduleItem>(); 
            foreach (var dateTime in schedule) 
            {
                items.Add(new ScheduleItem(payeeName, dateTime)); 
            }
            return items.ToArray(); 
        }
    }

    

    

    
}
