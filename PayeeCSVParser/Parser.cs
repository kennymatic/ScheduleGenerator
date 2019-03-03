using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using Util; 

namespace CSVItemParser
{
    public class Parser
    {
        public List<Payee> Payees { get; set; } = new List<Payee>(); 

        public void Parse()
        { 
            
            using (var reader = new StreamReader(@"data.csv")) 
            {
                using (var csvReader = new CsvReader(reader)) 
                {
                    var records = csvReader.GetRecords<Payee>(); 
                    foreach (var record in records) 
                    {
                        Payees.Add(record); 
                    }
                }
            }
        }
    }
}
