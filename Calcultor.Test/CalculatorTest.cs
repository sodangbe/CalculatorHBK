using CalculatorHBK;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calcultor.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Test_Calculate_Addition()
        {
            //Arrange 
            int expected = 10;

            Calculator myCalc = new Calculator("9", "1", "+");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void Test_Calculate_Substraction()
        {
            //Arrange 
            int expected = 11;
            Calculator myCalc = new Calculator("4", "-7", "-");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Calculate_Mulltiplication()
        {
            //Arrange 
            int expected = 64;

            Calculator myCalc = new Calculator("8", "8", "*");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Test_Calculate_Division()
        {
            //Arrange 
            int expected = 4;

            Calculator myCalc = new Calculator("12", "3", "/");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test_Calculate_DivisionbyZero()
        {
            //Arrange 
            Calculator myCalc = new Calculator("256", "0", "/");
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(256, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Calculate_AdditionWithEmptyString()
        {
            //Arrange 
            Calculator myCalc = new Calculator();
            myCalc.SetLeft(" ");
            myCalc.SetRight("423");
            myCalc.SetOperator("+");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(423, actual);


        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Calculate_AdditionWithString()
        {
            //Arrange 
            Calculator myCalc = new Calculator();
            myCalc.SetLeft("foo");
            myCalc.SetRight("14");
            myCalc.SetOperator("+");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(14, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Test_Calculate_ArithmeticOverflow()
        {
            //Arrange 
            Calculator myCalc = new Calculator();
            myCalc.SetLeft("2147483647");
            myCalc.SetRight("1");
            myCalc.SetOperator("+");

            //Act
            int actual = myCalc.Calculate();

            //Assert 
            Assert.AreEqual(-2147483648, actual);

        }
    }
}
