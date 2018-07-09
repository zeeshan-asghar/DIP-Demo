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
        public void IsMLARateDateValid()
        {
            DateTimeHelper sut = new DateTimeHelper();
            DateTime expected = new DateTime(2016, 10, 6, 0, 0, 0);

            Assert.That(sut.GetMLARateStartDate(), Is.EqualTo(expected).Within(2).Days);

        }

    }
}
