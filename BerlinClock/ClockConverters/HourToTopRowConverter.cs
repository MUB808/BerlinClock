using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class HourToTopRowConverter : ITimeConverter
    {
        public string ConvertTime(int aTime)
        {
            return String.Format("{3}{2}{1}{0}",
               TimeComparator.TimeComparison(aTime, 20),
               TimeComparator.TimeComparison(aTime, 15),
               TimeComparator.TimeComparison(aTime, 10),
               TimeComparator.TimeComparison(aTime, 5));
        }
    }
    
}
