using System; 
using System.Collections.Generic; 

namespace ScheduleStrategies
{
    public abstract class AbstractStrategy 
    {
        protected DateTime Until { get; set; }

        public AbstractStrategy(DateTime until) 
        {
            Until = until;
        }
        public abstract DateTime GetNextDate(DateTime currentDate); 

        public IEnumerable<DateTime> GenerateSchedule(DateTime startingDate)
        {
            List<DateTime> schedule = new List<DateTime>(); 
            DateTime nextDate; 
            while ((nextDate = GetNextDate(startingDate)) < Until) 
            {
                schedule.Add(nextDate); 
                startingDate = nextDate;
            }
            return schedule; 
        }
    }
}