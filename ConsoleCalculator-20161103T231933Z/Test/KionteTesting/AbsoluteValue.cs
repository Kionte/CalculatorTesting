using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
//using ConsoleCalculator;

namespace Test.KionteTesting
{
    /// <summary>
    /// Summary description for AbsoluteValue
    /// </summary>
    [TestClass]
    public class AbsoluteValue
    {
        public Double Calc(string expression)
        {
            Calculator calc = new Calculator();
            calc.Execute(expression);

            return calc.Answer;
        }

        [TestMethod]
        public void ABS_Pos()
        {
            Assert.AreEqual(1, Calc("abs(1)"));
        }
        [TestMethod]
        public void ABS_Pos_Add()
        {
            Assert.AreEqual(1, Calc("abs(1 + 0"));
        }
        [TestMethod]
        public void ABS_Pos_Sub()
        {
            Assert.AreEqual(1, Calc("abs(2 - 1)"));
        }
        [TestMethod]
        public void ABS_Pos_Mul()
        {
            Assert.AreEqual(1, Calc("abs(1 * 1)"));
        }
        [TestMethod]
        public void ABS_Pos_Div()
        {
            Assert.AreEqual(1, Calc("abs(1 / 1)")); 
        }

        [TestMethod]
        public void ABS_Pos_Exp()
        {
            Assert.AreEqual(1, Calc("abs(pow(1,1))"));
        }
        [TestMethod]
        public void ABS_Pos_Mod()
        {
            Assert.AreEqual(1, Calc("abs(3%2)"));
        }
        [TestMethod]
        public void ABS_Neg()
        {
            Assert.AreEqual(-1, Calc("abs(-1)"));
        }
        [TestMethod]
        public void ABS_Neg_Add()
        {
            Assert.AreEqual(-1, Calc("abs(-2 + 1)"));
        }
        [TestMethod]
        public void ABS_Neg_Sub()
        {
            Assert.AreEqual(-3, Calc("abs(-2 - 1)"));
        }
        [TestMethod]
        public void ABS_Neg_Mul()
        {
            Assert.AreEqual(-1, Calc("abs(-1 *1)"));
        }
        [TestMethod]
        public void ABS_Neg_Div()
        {
            Assert.AreEqual(-1, Calc("abs(-1 / 1)"));
        }

        [TestMethod]
        public void ABS_Neg_Exp()
        {
            Assert.AreEqual(-1, Calc("abs(pow(-1,1)"));
        }
        [TestMethod]
        public void ABS_Neg_Mod()
        {
            Assert.AreEqual(-1, Calc("abs(-3 % -2)"));
        }
    }
}
