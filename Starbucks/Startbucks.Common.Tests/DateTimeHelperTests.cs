using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Starbucks.Common;

namespace Startbucks.Common.Tests
{
    [TestFixture]
    public class DateTimeHelperTests
    {
        [TestCase("21/07/2016 12:05:30", "21/07/2016 13:05:30")]
        [TestCase("21/07/2016 04:05:30", "21/07/2016 05:05:30")]
        public void TestMethod(string datetime, string expected)
        {
            //arrange
            //act
            var result = DateTimeHelper.ConvertToDateTime(datetime);
            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
