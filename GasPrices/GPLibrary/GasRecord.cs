using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPLibrary
{
    public class GasRecord
    {
        public GasRecord(int month, int day, int year, double price)
        {
            Month = month;
            Day = day;
            Year = year;
            Price = price;
        }

        public int Month { get; set;  }
        public int Day { get; set; }   
        public int Year { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Month + "-" + Day + "-" + Year + ":" + Price;
        }
    }
}
