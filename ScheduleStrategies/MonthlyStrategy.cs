using System; 

namespace ScheduleStrategies
{
    internal class MonthlyStrategy : AbstractStrategy, IIntervalStrategy
    {
        public MonthlyStrategy(DateTime until) : base(until)
        {

        }

        public override DateTime GetNextDate(DateTime currentDate)
        {
            var day = currentDate.Day; 
            var nextMonthDate = currentDate.AddMonths(1); 
            var daysInNextMonth = DateTime.DaysInMonth(nextMonthDate.Year, nextMonthDate.Day); 
            var nextDate = (day > daysInNextMonth) ? daysInNextMonth : day; 
            return new DateTime(nextMonthDate.Year, nextMonthDate.Month, nextDate);
        }
    }
}