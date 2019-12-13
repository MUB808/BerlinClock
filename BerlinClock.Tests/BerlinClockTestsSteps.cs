using System;
using TechTalk.SpecFlow;
using BerlinClock;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BerlinClock.Tests
{
    [Binding]
    public class BerlinClockTestsSteps
    {
        #region Private properties

        BerlinClocks berlinClocks;
        string clockTime;
        string r_clockTime;

        #endregion

        [When(@"The time is ""(.*)""")]
        public void WhenTheTimeIs(string time)
        {
            berlinClocks = new BerlinClocks();
            clockTime = time;
        }
        
        [Then(@"The clock should look like")]
        public void ThenTheClockShouldLookLike(string correctanswer)
        {
            r_clockTime = berlinClocks.Generate(clockTime);
            Assert.AreEqual(correctanswer, r_clockTime);
        }
    }
}
