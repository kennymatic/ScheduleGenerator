using System;
using ScheduleStrategies;

namespace Schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            var parser = new CSVItemParser.Parser();
            parser.Parse();
            var generator = new ScheduleGenerator(); 
            var schedule = generator.Generate(parser.Payees); 
            foreach (var str in schedule) 
            {
                Console.WriteLine(str); 
            }
        }
    }
}
