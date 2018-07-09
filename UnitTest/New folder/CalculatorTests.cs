using System;
using System.Collections;
using Model;
using NUnit;
using NUnit.Framework;

namespace UnitTest
{
 

    [TestFixture]
    public class CalculatorTests
    {

        Calculator sut;
        [SetUp]
        public void BeforeEachTest()
        {
            Console.WriteLine($"Before {TestContext.CurrentContext.Test.Name}");
            sut = new Calculator();
        }

        [TearDown]
        public void AfterEachTest()
        {
            Console.WriteLine($"After {TestContext.CurrentContext.Test.Name}");
            sut = null;
        }

        [OneTimeSetUp]
        public void Init()
        {
            Console.WriteLine("Before test suite startup.");
        }

        [OneTimeTearDown]
        public void End()
        {
            Console.WriteLine("after test suite finish.");
        }
         
        [TestCase(15,5,10)]
        [TestCase(50, 10, 20)]
        public void ShouldSubtractTwoNumbers(int firstNum, int secondNum, int expected)
        {
            Assert.That(sut.Subtract(firstNum, secondNum), Is.EqualTo(expected));

        }


       [TestCaseSource(typeof(TestCaseData))]
        public void ShouldSubtractTwoNumbersByTestData(int firstNum, int secondNum, int expected)
        {
            Assert.That(sut.Subtract(firstNum, secondNum), Is.EqualTo(expected));

        }

        [Test]
         //[MaxTime(4000)]
        public void ShouldAddTowNumbers()
        {
             
            int excepectedResult = 3;
            Assert.That(sut.Add(1, 2), Is.EqualTo(excepectedResult));
        }

        [Test]
        public void ShouldMultiplyTowNumbers()
        {
             
            int excepectedResult = 2;
            Assert.That(sut.Multiply(1, 2), Is.EqualTo(excepectedResult));
        }


        [Test]
        public void ShouldAddDoublesWithoutTolerance()
        {
             
            double excepectedResult = 3.3;
            Assert.That(sut.Add(1.1, 2.2), Is.EqualTo(excepectedResult));
        }

        [Test]
        public void ShouldAddDoublesWithTolerance()
        {
             
            double excepectedResult = 3.3;
            Assert.That(sut.Add(1.1, 2.2), Is.EqualTo(excepectedResult)
                                                .Within(.01));

            
            //within(1).Prcent

            //Equalto(30)within(100)
        }

       [Test]
        public void DivideByZeroException()
        {
             

            Assert.That(() => sut.Divide(200, 0), Throws.TypeOf<DivideByZeroException>());


        }

    }
}
