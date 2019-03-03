using System;
using System.Collections.Generic;

namespace Util 
{
    public class ScheduleItem
    {
        public string PayeeName { get; set; }
        public DateTime DateTime { get; set; }

        public ScheduleItem(string payeeName, DateTime dateTime) 
        {
            PayeeName = payeeName;
            DateTime = dateTime; 
        }

        public override string ToString()
        {
            return $"{PayeeName},{DateTime.ToShortDateString()}";   
        }
    }
}