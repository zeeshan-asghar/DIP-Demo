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
    public class CalculatorTests
    {
        Calculator sut;
        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine($"Before  {TestContext.CurrentContext.Test.Name}");
            sut = new Calculator();
        }

        [TearDown]
        public void AtfterEachTest()
        {
            sut = null;
        }

        [OneTimeSetUp]
        public void Init()
        {
            Console.WriteLine("Fixture start");
        }

        [OneTimeTearDown]
        public void End()
        {
            Console.WriteLine("End fixture");
        }


        [Test]
        public void ShouldAddTwoNumber()
        {

            int expected = 3;

            Assert.That(sut.Add(1, 2), Is.EqualTo(expected));
        }

        [Test]
        public void ShouldAddTwoDouble()
        {

            double expected = 3.3;

            Assert.That(sut.Add(1.1, 2.2), Is.EqualTo(expected)
                .Within(1).Percent);

        }


        [TestCase(5, 2, 3)]
        [TestCase(15, 2, 13)]
        public void ShouldSubtractTwoNumbers(int firstVal
            , int secondVal, int expected)
        {

            Assert.That(sut.Subtract(firstVal, secondVal), Is.EqualTo(expected));
        }


        [Test]
        public void ShouldHavePositiveValue()
        {

            int expected = 3;

            Assert.That(sut.Add(1, 2), Is.Positive);
        }

    }
}
