using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class SecondToRowConverter : ITimeConverter
    {
        public string ConvertTime(int aTime)
        {
            return aTime == 0 ? "Y" : aTime % 2 == 0 ? "Y" : "O";
        }
    }
}
