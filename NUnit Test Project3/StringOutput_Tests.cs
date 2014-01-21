using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FizzBuzz;

namespace NUnit_Test_Project3
{
    [TestFixture]
    public class NUnit_Test_Class1
    {
        [TestFixtureSetUp]
        public void InitFixture()
        {

        }


        [Test]
       public void StringOutput_Given1To5_ReturnsCorrectOutput()
        {
            //Arrange
            string expected = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\n";
            //Act
            var result = FizzBuzz.HelperMethods.StringOutput(1, 5, Environment.NewLine);
            //Assert
            Assert.AreEqual(expected, result, "Wrong result returned");
        }

        
        [Test]
        
        public void StringOutput_SequenceStartingWith10_OutputStartsWithRightNumber()
        
        {
            //Arrange
            string expected = "Buzz\r\n11\r\nFizz\r\n13";
            //Act
            var result = FizzBuzz.HelperMethods.StringOutput(10, 20, Environment.NewLine);
            //Assert
            Assert.That(result.StartsWith(expected), "Result does not start with expected");
        }

       
        [Test]
        public void StringOutput_SequenceEndingWith100_OutputEndsWithRightNmber()
        {
            //Arrange
            string expected = "98\r\nFizz\r\nBuzz\r\n";
            //Act
            var result = FizzBuzz.HelperMethods.StringOutput(95,100, Environment.NewLine);
            //Assert
            Assert.That(result.EndsWith(expected), "Result doesn't end with right number");
        }
        [TestFixtureTearDown]
        public void CleanupFixture()
        {

        }
    }
}
