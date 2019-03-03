using System; 

namespace ScheduleStrategies
{
    internal class BiWeeklyStrategy : AbstractStrategy, IIntervalStrategy
    {
        public BiWeeklyStrategy(DateTime until) : base(until)
        {

        }
        public override DateTime GetNextDate(DateTime currentDate)
        {
            return currentDate.AddDays(14);
        }
    }
}