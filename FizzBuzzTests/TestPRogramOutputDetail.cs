using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzConsole;

namespace FizzBuzzTests
{
    [TestClass]
    public class TestPRogramOutputDetail
    {
        /// <summary>
        /// Validate line output (string) when the value is 5.
        /// Expect FIZZ
        /// </summary>
        [TestMethod]
        public void TestOuputLineMult5()
        {
            // Arrange
            const int input = 5;


            // Setup
            var result = input.FizzBuzz();

            // Assert
            Assert.AreEqual(result,"005 Buzz");
        }

        /// <summary>
        /// Validate line output (string) when the value is 3.
        /// Expect BUZZ
        /// </summary>
        [TestMethod]
        public void TestOuputLineMult3()
        {
            // Arrange
            const int input = 3;


            // Setup
            var result = Extensions.FizzBuzz(input);

            // Assert
            Assert.AreEqual(result, "003 Fizz");
        }

        /// <summary>
        /// Validate line output (string) when the value is 3.
        /// Expect FIZZBUZZ 
        /// </summary>
        [TestMethod]
        public void TestOuputLineMult15()
        {
            // Arrange
            const int input = 15;


            // Setup
            var result = input.FizzBuzz();

            // Assert
            Assert.AreEqual(result, "015 FizzBuzz");
        }

        /// <summary>
        /// Validate line output (string) when the value is 3.
        /// Expect nothing 
        /// </summary>
        [TestMethod]
        public void TestOuputLineMult16()
        {
            // Arrange
            const int input = 16;


            // Setup
            var result = input.FizzBuzz();

            // Assert
            Assert.AreEqual(result, "016");
        }

        [TestMethod]
        public void TestOuputLineHeader()
        {
            // Arrange

            // Setup
            var result = StaticMethods.PrintHeader();

            // Assert
            Assert.AreEqual(result, "Fizz: Multiple of 3.\r\nBuzz: Multiple of 5.\r\nFizzBuzz: Multiple of both 3 and 5.\r\n\r\n");
        }
        
    }
}
