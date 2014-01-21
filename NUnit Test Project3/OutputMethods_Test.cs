using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FizzBuzz;
using System.Web;

namespace NUnit_Test_Project3
{
    [TestFixture]
    public class OutputMethods_Test
    {
        [TestFixtureSetUp]
        public void InitFixture()
        {

        }

        
        [Test]
        public void ConsoleOutput_Numbers1To5_ProduceCorrectResultsInOuputTextWrite()
        {
            //Arrange
            string expected = "1\r\n2\r\nFizz\r\n4\r\nBuzz\r\n";
            var sb = new StringBuilder();
            var outStream = new StringWriter(sb);
            //Act
            HelperMethods.ConsoleOut(outStream, 1, 5);
            var actual = sb.ToString();
            //Assert
            Assert.AreEqual(expected, actual, "Wrong result");
        }

        
        [Test]
        public void WebOutput_Number1to5_ProducesCorrectResultsInPageContent()
        {
            //Arrange
            var sb = new StringBuilder();
            var tw = new StringWriter(sb);
            string expected = "1<br>2<br>Fizz<br>4<br>Buzz<br>";
            var webPage = new HttpResponse(tw);
            //Act
            HelperMethods.WebOutput(webPage, 1, 5);
            //Assert
            Assert.AreEqual(expected, sb.ToString(), "Wrong result");
        }
        [TestFixtureTearDown]
        public void CleanupFixture()
        {

        }
    }
}
