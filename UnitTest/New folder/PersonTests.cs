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
    public class PersonTests
    {

        [Test]
        public void PersonShouldHaveLastName()
        {
            var sut = new Person { FirstName = "Muhammad", EmailAddress = "muhammad.usama@aajtech.com", PhoneNo = "042-3588888" };

            Assert.That(sut.LastName, Is.Not.Null);
        }

       [Test]
        public void IsPersonEligibleToBuyFirearm()
        {
            var person = new Person { DateOfBirth=new DateTime(2010,2,8), FirstName="Zeeshan", LastName="Asghar" };
            var sutPersonBusiness = new PersonBusinessHelper();

             
            Assert.That(sutPersonBusiness.IsPersonEligibleToBuyFirearm(person), Is.True);
        }
    }
}
