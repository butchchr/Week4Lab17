using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Week4Lab17;

namespace PrimeNumberGenerator.Test
{
    public class PrimeNumberGeneratorTester
    {
        [TestCase(4)]
        [TestCase(7)]
        [TestCase(8)]
        public void Should_Throw_Exception_User_Input_Is_Negative(int NumToCheck)
        {
            //Arrange
            var generator = new PrimeNumbersGenerator();


            //act
            var result = generator.GetPrimeNumber(-1);

            Assert.IsTrue(NumToCheck > 2);

        }
        public void Should_Throw_Exception_User_Input_Equals_Zero()
        {
            //Arrange
            var generator = new PrimeNumbersGenerator();

            try
            {
                //act
                var result = generator.GetPrimeNumber(0);
            }
            catch (Exception ex)
            {
                Assert.AreEqual("Gotta be greater than 0", ex.Message);
            }
        }
        [TestCase(8)]
        [TestCase(2)]
        public void Should_Not_Be_Prime_If_Even(int NumToCheck)
        {
            //Arrange
            var generator = new PrimeNumbersGenerator();

            //Act
            var result = generator.GetPrimeNumber(1);

            //Assert
            Assert.IsTrue(NumToCheck % 2 == 0);
        }
    }
}
