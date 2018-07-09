using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;

namespace UnitTest
{
    [TestFixture]
    public class StrJinTests
    {

        [Test]
        public void ShouldConcateString() {
            StringJoiner sut = new StringJoiner();
            string expected = "Usama Khan";
            Assert.That(sut.Join("Usama", "Khan"), Is.EqualTo(expected));

        }

        [Test]
        public void ShouldConcateStringCasSenstive()
        {
            StringJoiner sut = new StringJoiner();
            string expected = "USAMA KHAN";
            Assert.That(sut.Join("Usama", "Khan"), Is.EqualTo(expected).IgnoreCase);

        }


        [Test]
        public void ShouldJoinAndTestNotEqualString()
        {
            string expected = "Usama Khan";
            StringJoiner sut = new StringJoiner();

            Assert.That(sut.Join("MUhammad", "Usama"), Is.Not.EqualTo(expected));
        }
    }
}
