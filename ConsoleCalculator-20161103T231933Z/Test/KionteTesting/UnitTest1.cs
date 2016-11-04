using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    [TestClass]
    public class UnitTest1
    {
        public double Calc(string expression)
        {
            Calculator calc = new Calculator();
            calc.Execute(expression);

            return calc.Answer;

        }
        [TestMethod]
        public void DecimalPrecision_M()
        {
            Assert.AreEqual(1, Calc("(1/3) * 3"));
        }
        [TestMethod]
        public void DecimalPrecision_D()
        {
            Assert.AreEqual(3, Calc("1 / (1/3)"));
        }
        [TestMethod]
        public void DecimalPrecision_NM()
        {
            Assert.AreEqual(-1, Calc("-(1/3) * 3"));
        }
        [TestMethod]
        public void DecimalPrecision_ND()
        {
            Assert.AreEqual(-3, Calc("1 / -(1/3)"));
        }

    }
}
