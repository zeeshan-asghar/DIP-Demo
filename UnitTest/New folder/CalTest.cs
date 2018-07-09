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
   public class CalTest
    {
        Calculator sut;
        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine($"Before executing {TestContext.CurrentContext.Test.Name}");
            sut = new Calculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine($"After executing {TestContext.CurrentContext.Test.Name}");
            sut = null;
        }

        [OneTimeSetUp]
        public void init()
        {

        }

        

        [Test]
        public void ShouldAddTwoNumbers()
        {
            int expected = 3;
           // Calculator sut = new Calculator();
            Assert.That(sut.Add(1, 2), Is.EqualTo(expected));
        }

       [Test]
        public void ShouldAddTwoDoubles()
        {
            double expected = 3.3;
          //  Calculator sut = new Calculator();

            Assert.That(sut.Add(1.1, 2.2), Is.EqualTo(expected).Within(.001));
                
        }

        [Test]
        [Ignore("Test")]
        public void ShouldThrowExceptionWhenDivideByZero()
        {
         //   Calculator sut = new Calculator();

            Assert.That(sut.Divide(50, 0), Throws.TypeOf<DivideByZeroException>());
        }

    }
}
