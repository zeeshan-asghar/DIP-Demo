using Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestFixture]
   public class DateTimeHelperTests
    {

        [Test]
        public void shouldHaveMinMLADate()
        {
            var sutDateTimeHelper = new DateTimeHelper();

            DateTime expectedResult = new DateTime(2016, 10, 3,0,0,0);

            Assert.That(sutDateTimeHelper.GetMLARateStartDate(),
                Is.EqualTo(expectedResult));
            //.Within(1).Hours
            //.Within(3601000).Milliseconds
        }

    }
}
