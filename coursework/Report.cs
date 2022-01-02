using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coursework
{
    internal class Report
    {
        public class MyMappedCSVFile
        {
            public string Category { get; set; }
            public string TotalPeople { get; set; }

            public MyMappedCSVFile(string category, string totalPeople)
            {
                Category = category;
                TotalPeople = totalPeople;
            }
        }
    }
}
