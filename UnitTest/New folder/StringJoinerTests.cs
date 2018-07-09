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
    public class StringJoinerTests
    {

        [Test]
        public void shouldJoinString()
        {
            var sutStringJoiner = new StringJoiner();
            string expectedResult = "Usama Khan";

            var fullName = sutStringJoiner.Join("Usama", "Khan");

            Assert.That(fullName, Is.EqualTo(expectedResult));
        }

        [Test]
        public void shouldJoinStringCaseInsentive()
        {
            var sutStringJoiner = new StringJoiner();
            string expectedResult = "USAMA KHAN";

            var fullName = sutStringJoiner.Join("Usama", "Khan");

            Assert.That(fullName, Is.EqualTo(expectedResult).IgnoreCase);
        }


        [Test]
        public void shouldJoinNotEqualString()
        {
            var sutStringJoiner = new StringJoiner();
            string expectedResult = "USAMA KHAN";

            var fullName = sutStringJoiner.Join("Muhammad", "Usama");

            Assert.That(fullName, Is.Not.EqualTo(expectedResult).IgnoreCase);
        }
    }
}
