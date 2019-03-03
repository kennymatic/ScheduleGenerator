using System; 

namespace ScheduleStrategies
{
    internal class WeeklyStrategy : AbstractStrategy, IIntervalStrategy
    {
        public WeeklyStrategy(DateTime until) : base(until)
        {

        }

        public override DateTime GetNextDate(DateTime currentDate)
        {
            return currentDate.AddDays(7);
        }
    }
}