using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock
{
    public class BerlinClocks
    {
        #region Private Fields Region

        readonly ITimeConverter SecondToRowConverter;
        readonly ITimeConverter HourToTopRowConverter;
        readonly ITimeConverter HourToBottomRowConverter;
        readonly ITimeConverter MinuteToTopConverter;
        readonly ITimeConverter MinuteToBottomRowConverter;

        #endregion

        #region Constructors region
        public BerlinClocks() : this(
            new SecondToRowConverter(),
            new HourToTopRowConverter(),
            new HourToBottomRowConverter(),
            new MinuteToTopConverter(),
            new MinuteToBottomRowConverter())
        {
        }

        public BerlinClocks(
            SecondToRowConverter secondToRowConverter,
            HourToTopRowConverter hourToTopRowConverter,
            HourToBottomRowConverter hourToBottomRowConverter,
            MinuteToTopConverter minuteToTopConverter,
            MinuteToBottomRowConverter minuteToBottomRowConverter)
        {
            SecondToRowConverter = secondToRowConverter;
            HourToTopRowConverter = hourToTopRowConverter;
            HourToBottomRowConverter = hourToBottomRowConverter;
            MinuteToTopConverter = minuteToTopConverter;
            MinuteToBottomRowConverter = minuteToBottomRowConverter;
        }

        #endregion

        public string Generate(String theTime)
        {
            if (theTime.Equals("24:00:00"))
            {
                return String.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}",
                     SecondToRowConverter.ConvertTime(0),
                     HourToTopRowConverter.ConvertTime(24),
                     HourToBottomRowConverter.ConvertTime(4),
                     MinuteToTopConverter.ConvertTime(0),
                     MinuteToBottomRowConverter.ConvertTime(0));
            }
            else 
            {
                DateTime time = Convert.ToDateTime(theTime);
                return String.Format("{0}\r\n{1}\r\n{2}\r\n{3}\r\n{4}",
                    SecondToRowConverter.ConvertTime(time.Second),
                    HourToTopRowConverter.ConvertTime(time.Hour),
                    HourToBottomRowConverter.ConvertTime(time.Hour),
                    MinuteToTopConverter.ConvertTime(time.Minute),
                    MinuteToBottomRowConverter.ConvertTime(time.Minute));
            }
        }


    }
}
