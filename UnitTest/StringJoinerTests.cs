using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using NUnit.Framework;
using System;


namespace UnitTest
{
    [TestFixture]
    public class StringJoinerTests
    {
        //[Test]
        //public void ShouldJoinTwoStrings()
        //{

        //    String expected = "USAMA KHAN";
        //    StringJoiner sut = new StringJoiner();

        //    //Assert.That(sut.Join("Usama", "Khan"), Is.EqualTo(expected).IgnoreCase);

        //}


        [Test]
        public void ShouldCompareTwoStrings()
        {

            String expected = "USAMA KHAN";
            StringJoiner sut = new StringJoiner();

            sut.Join("Muhammad", "Usama");
             
            Assert.That(sut.Result, Is.Not.EqualTo(expected));
             
        }
    }
}
