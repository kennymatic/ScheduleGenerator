using System;
using System.Collections.Generic;

namespace ScheduleStrategies
{
    public interface IIntervalStrategy 
    {
        IEnumerable<DateTime> GenerateSchedule(DateTime startingDate); 
    }
}