using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    // This class will contain test cases that will perform expressions with different variations of deciaml values 

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
        public void DecimalPrecision_M2()
        {
            Assert.AreEqual(1, Calc("(1/4) * 4"));
        }
        [TestMethod]
        public void DecimalPrecision_M3()
        {
            Assert.AreEqual(1, Calc("(1/2) * 2"));
        }
        [TestMethod]
        public void DecimalPrecision_D()
        {
            Assert.AreEqual(3, Calc("1 / (1/3)"));
        }
        [TestMethod]
        public void DecimalPrecision_D2()
        {
            Assert.AreEqual(4, Calc("1 / (1/4)"));
        }
        [TestMethod]
        public void DecimalPrecision_D3()
        {
            Assert.AreEqual(2, Calc("1 / (1/2)"));
        }
        [TestMethod]
        public void DecimalPrecision_A()
        {
            Assert.AreEqual(1, Calc("(1/3) + (2/3)"));
        }
        [TestMethod]
        public void DecimalPrecision_A2()
        {
            Assert.AreEqual(1, Calc("(1/4) + (3/4)"));
        }
        public void DecimalPrecision_A3()
        {
            Assert.AreEqual(1, Calc("(1/2) + (1/2)"));
        }
        [TestMethod]
        public void DecimalPrecision_S()
        {
            Assert.AreEqual(0, Calc("1 - (1/3) - (2/3)"));
        }
        [TestMethod]
        public void DecimalPrecision_S2()
        {
            Assert.AreEqual(0, Calc("1 - (1/4) - (3/4)"));
        }
        [TestMethod]
        public void DecimalPrecision_S3()
        {
            Assert.AreEqual(0, Calc("1 - (1/2) - (1/2)"));
        }
       [TestMethod]
        public void DecimalPrecision_E()
        {
            Assert.AreEqual(2, Calc("pow(8,(1/3))"));
        }
       [TestMethod]
        public void DecimalPrecision_E2()
        {
            Assert.AreEqual(2, Calc("pow(16,(1/4))"));
        }
       [TestMethod]
       public void DeciamlPrecision_E3()
        {
            Assert.AreEqual(2, Calc("pow(4,(1/2))"));
        }
        [TestMethod]
        public void DecimalPrecision_NM()
        {
            Assert.AreEqual(-1, Calc("-(1/3) * 3"));
        }
        [TestMethod]
        public void DeciamlPrecision_NM2()
        {
            Assert.AreEqual(-1, Calc("-(1/4) * 4"));
        }
        [TestMethod]
        public void DecimalPrecision_NM3()
        {
            Assert.AreEqual(-1, Calc("-(1/2) * 2"));
        }
        [TestMethod]
        public void DecimalPrecision_ND()
        {
            Assert.AreEqual(-3, Calc("1 / -(1/3)"));
        }
        [TestMethod]
        public void DeciamlPrecision_ND2()
        {
            Assert.AreEqual(-4, Calc("1 / -(1/4)"));
        }
        [TestMethod]
        public void DecimalPrecision_ND3()
        {
            Assert.AreEqual(-2, Calc("1/ -(1/2)"));
        }
        [TestMethod]
        public void DecimalPrecision_NA()
        {
            Assert.AreEqual(-1, Calc("-(1/3) + -(2/3)"));
        }
        [TestMethod]
        public void DecimalPrecision_NA2()
        {
            Assert.AreEqual(-1, Calc("-(1/4) + -(3/4)"));
        }
        [TestMethod]
        public void DecimalPrecision_NA3()
        {
            Assert.AreEqual(-1, Calc("-(1/2) + -(1/2)"));
        }
        [TestMethod]
        public void DecimalPrecision_NS()
        {
            Assert.AreEqual(0, Calc("-1 - -(1/3) - -(2/3)"));
        }
        [TestMethod]
        public void DeciamlPrecision_NS2()
        {
            Assert.AreEqual(0, Calc("1 - -(1/4) - -(3/4)"));
        }
        [TestMethod]
        public void DeciamlPrecision_NS3()
        {
            Assert.AreEqual(0, Calc("1 - -(1/2) - -(1/2)"));
        }
        //  [TestMethod]
        public void DecimalPrecision_NE()
        {
            Assert.AreEqual(0.5, Calc("8^-(1/3)"));
        }
        // [TestMethod]
        public void DecimalPrecision_NE2()
        {
            Assert.AreEqual(0.5, Calc("16^-(1/4)"));
        }
        // [TestMethod]
        public void DeciamlPrecision_NE3()
        {
            Assert.AreEqual(0.5, Calc("4^-(1/2)"));
        }

    }
}
