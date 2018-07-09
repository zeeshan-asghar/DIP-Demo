using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Model;
namespace UnitTest
{
  [TestFixture]
    public class DtTests
    {
        [Test]
        public void IsCustomerEligibleForMLARate()
        {
            DateTimeHelper sut = new DateTimeHelper();
            DateTime expected = new DateTime(2016, 10, 5, 0, 0, 0);

            Assert.That(sut.GetMLARateStartDate(), Is.EqualTo(expected).Within(1).Days);
        }
    }
}
