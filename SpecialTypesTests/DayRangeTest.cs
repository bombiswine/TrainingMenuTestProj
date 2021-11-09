using System;
using System.Globalization;
using NUnit.Framework;
using TrainingMenu.SpecialTypes;

namespace Test.TrainingMenu.SpecialTypesTests
{
    [TestFixture]
    public class DayRangeTest
    {
        [TestCase("10.04.2009", "12.12.2012", "01.01.2001", "12.04.2009", 3)]
        [TestCase("10.04.2009", "12.12.2012", "01.01.2001", "10.04.2009", 1)]
        [TestCase("01.01.2000", "01.02.2000", "10.06.2020", "13.09.2021", 0)]
        [TestCase("24.06.2002", "24.06.2002", "24.06.2002", "24.06.2002", 1)]
        public void CountDaysInIntersection_Validate(string sFirstRangeBeg,  
                                                     string sFirstRangeEnd, 
                                                     string sSecondRangeBeg, 
                                                     string sSecondRangeEnd, 
                                                     int    iIntersectionLength)
        {
            const string sFormat = "dd.MM.yyyy";
            IFormatProvider FormatProvider = CultureInfo.InvariantCulture;
            DateTimeStyles  Style = DateTimeStyles.None;
            
            DateTime.TryParseExact(sFirstRangeBeg, sFormat, FormatProvider, Style, out DateTime dFirstRangeBeg);
            DateTime.TryParseExact(sFirstRangeEnd, sFormat, FormatProvider, Style, out DateTime dFirstRangeEnd);
            DateTime.TryParseExact(sSecondRangeBeg, sFormat, FormatProvider, Style, out DateTime dSecondRangeBeg);
            DateTime.TryParseExact(sSecondRangeEnd, sFormat, FormatProvider, Style, out DateTime dSecondRangeEnd);

            DaysRange firstRange = new DaysRange(dFirstRangeBeg, dFirstRangeEnd);
            DaysRange secondRange = new DaysRange(dSecondRangeBeg, dSecondRangeEnd);

            Assert.AreEqual(DaysRange.CountDaysInIntersectionOf(firstRange, secondRange), iIntersectionLength);
        }
    }
}
