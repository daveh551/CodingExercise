using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using HeadspringExercize;

namespace NUnit_Test_Project3
{
    [TestFixture]
    public class Test_Monkey
    {
        [TestFixtureSetUp]
        public void InitFixture()
        {

        }


        [Test]
        [TestCase(1, "1")]
        [TestCase(2, "2")]
        [TestCase(3, "Fizz")]
        [TestCase(4, "4")]
        [TestCase(5, "Buzz")]
        [TestCase(15, "FizzBuzz")]
        public void Monkey_GivenInputNumber_ReturnsCorrectResult(int input, string expectedResult)
        {
            var result = FizzBuzz.HelperMethods.Fizzer(input);
            //Assert
            Assert.AreEqual(expectedResult, result, "Message");
        }
        [TestFixtureTearDown]
        public void CleanupFixture()
        {

        }
    }
}
