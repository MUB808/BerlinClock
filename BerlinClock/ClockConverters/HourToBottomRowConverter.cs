using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class HourToBottomRowConverter : ITimeConverter
    {
        public string ConvertTime(int aTime)
        {
            return String.Format("{3}{2}{1}{0}", 
                TimeComparator.TimeComparison(aTime % 10, 4),
                TimeComparator.TimeComparison(aTime % 10, 3),
                TimeComparator.TimeComparison(aTime % 10, 2),
                TimeComparator.TimeComparison(aTime % 10, 1));
        }
    }
}
