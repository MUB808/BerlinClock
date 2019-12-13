using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class MinuteToTopConverter : ITimeConverter
    {
        public string ConvertTime(int aTime)
        {
            return String.Format("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}",
                 TimeComparator.TimeComparison(aTime, 5, 'Y'),
                 TimeComparator.TimeComparison(aTime, 10, 'Y'),
                 TimeComparator.TimeComparison(aTime, 15),
                 TimeComparator.TimeComparison(aTime, 20, 'Y'),
                 TimeComparator.TimeComparison(aTime, 25, 'Y'),
                 TimeComparator.TimeComparison(aTime, 30),
                 TimeComparator.TimeComparison(aTime, 35, 'Y'),
                 TimeComparator.TimeComparison(aTime, 40, 'Y'),
                 TimeComparator.TimeComparison(aTime, 45),
                 TimeComparator.TimeComparison(aTime, 50, 'Y'),
                 TimeComparator.TimeComparison(aTime, 55, 'Y'));

        }
    }
}
