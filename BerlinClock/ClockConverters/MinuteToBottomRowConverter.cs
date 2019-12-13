using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class MinuteToBottomRowConverter : ITimeConverter
    {
        public string ConvertTime(int aTime)
        {
            return String.Format("{0}{1}{2}{3}",
                TimeComparator.TimeComparison(aTime % 5, 1, 'Y'),
                TimeComparator.TimeComparison(aTime % 5, 2, 'Y'),
                TimeComparator.TimeComparison(aTime % 5, 3, 'Y'),
                TimeComparator.TimeComparison(aTime % 5, 4, 'Y'));
        }
    }
}
