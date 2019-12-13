using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public static class TimeComparator 
    {
        public static char TimeComparison(int value, int valueToCompare, char returnTrueValue = 'R', char returnFalseValue = 'O')
        {
            if (value < valueToCompare) return returnFalseValue;
            return returnTrueValue;
        }
    }
}
