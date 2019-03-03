using System;

namespace Util
{
    public class Payee
    {
        private FrequencyType FrequencyType { get; set; } = FrequencyType.Monthly;
        public string Name { get; set; }
        public DateTime LastDate { get; set; }
        
        public string Frequency
        {
            get
            {
                return FrequencyType.ToString();
            }
            set
            {
                FrequencyType = (FrequencyType)Enum.Parse(typeof(FrequencyType), value);
            }
        }

        public FrequencyType GetFrequencyType()
        {
            return FrequencyType; 
        }
    }
}