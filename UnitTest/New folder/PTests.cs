using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace UnitTest
{
    [TestFixture]
    public class PTests
    {
        [Test]
        public void PersonShouldHaveLastName()
        {
            Person sut = new Person { FirstName="Usama", PhoneNo="1233333" };

            Assert.That(sut.LastName, Is.Not.Null);
        }

        [Test]
        public void IsPersonEligibleToBuyFirearm()
        {
            Person _person = new Person { FirstName = "Usama", PhoneNo = "1233333", DateOfBirth=new DateTime(1995,1,1) };

            PersonBusinessHelper sut = new PersonBusinessHelper();

            Assert.That(sut.IsPersonEligibleToBuyFirearm(_person), Is.True);

        }

    }
}
