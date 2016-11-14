using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    [TestClass]
    public class MaxMinPowAbsFunctions
 
    {

        public double CalcSim(string input)//This string is what will be sent to the calculator to be evaluated. ex 2 + 2
        {
            Calculator calc = new Calculator();//Sets up calculator and sends the input string to the calculator to execute. 
            calc.Execute(input);
            return calc.Answer;//Returns the answer double from the evaluated expression.
        }
/// <summary>
/// ///////////////////////////Testing max function//////////////////////////////////////////////////////////////////////////
/// </summary>

        [TestMethod]
        public void maxFxn()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("max(2, 5)"));
        }


        [TestMethod]
        public void maxFxn2()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("max(5, 2)"));
        }

        [TestMethod]//3
        public void maxFxnExtraSpaces()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("max(5 ,  2 )"));
        }


        [TestMethod]//4
        public void maxFxnWithoutComma()
        {
            bool ex = false;
            try
            {
                CalcSim("max( 5 2)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }


        [TestMethod]
        public void maxOneNum()
        {
            bool ex = false;
            try
            {
                CalcSim("max(5)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//6
        public void maxWithoutParenthesis()
        {
            bool ex = false;
            try
            {
                CalcSim("max5");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }


        [TestMethod]//7
        public void maxwithUndeclaredVariableandNum()
        {
            bool ex = false;
            try
            {
                CalcSim("max(b, 4)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//8
        public void maxwithUndeclaredVariable()
        {
            bool ex = false;
            try
            {
                CalcSim("max(b)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//9
        public void maxwithUndeclaredVariables()
        {
            bool ex = false;
            try
            {
                CalcSim("max(b, c)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//10
        public void maxwithDeclaredVariable()
        {
            bool ex = false;
            try
            {
                CalcSim("b =5");
                CalcSim("max(b, 4)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, false);
        }

        [TestMethod]//11
        public void maxwithNegativeNum()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("max(-5, 5)"));
        }

        [TestMethod]//12
        public void maxwithNegativeNums()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("max(-5, -7)"));
        }

        [TestMethod]//13
        public void maxPlusNum()
        {
            double math = 8;
            Assert.AreEqual(math, CalcSim("5 + max(2, 3"));
        }

        [TestMethod]//14
        public void maxMinusNum()
        {
            double math = 2;
            Assert.AreEqual(math, CalcSim("5 - max(2, 3"));
        }

        [TestMethod]//15
        public void maxTimesNum()
        {
            double math = 15;
            Assert.AreEqual(math, CalcSim("5 * max(2, 3"));
        }

        [TestMethod]//16
        public void maxDividedNum()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("15 / max(2, 3"));
        }

        [TestMethod]//17
        public void maxMinustoNeg()
        {
            double math = -2;
            Assert.AreEqual(math, CalcSim("3 - max(2, 5"));
        }

        /////////////////////////////////////////////////////Testing Min Function////////////////////////////////////////////


        [TestMethod]//18
        public void minFxn()
        {
            double math = 2;
            Assert.AreEqual(math, CalcSim("min(2, 5)"));
        }


        [TestMethod]//19
        public void minFxn2()
        {
            double math = 2;
            Assert.AreEqual(math, CalcSim("min(5, 2)"));
        }

        [TestMethod]//20
        public void minFxnExtraSpaces()
        {
            double math = 2;
            Assert.AreEqual(math, CalcSim("min(5 ,  2 )"));
        }


        [TestMethod]//21
        public void minFxnWithoutComma()
        {
            bool ex = false;
            try
            {
                CalcSim("min( 5 2)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }


        [TestMethod]//22
        public void minOneNum()
        {
            bool ex = false;
            try
            {
                CalcSim("min(5)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//23
        public void minWithoutParenthesis()
        {
            bool ex = false;
            try
            {
                CalcSim("min5");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }


        [TestMethod]//24
        public void minWithUndeclaredVariableandNum()
        {
            bool ex = false;
            try
            {
                CalcSim("min(b, 4)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//25
        public void minWithUndeclaredVariable()
        {
            bool ex = false;
            try
            {
                CalcSim("min(b)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//26
        public void minWithUndeclaredVariables()
        {
            bool ex = false;
            try
            {
                CalcSim("min(b, c)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//27
        public void minWithDeclaredVariable()
        {
            bool ex = false;
            try
            {
                CalcSim("b =5");
                CalcSim("min(b, 4)");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, false);
        }

        [TestMethod]//28
        public void minWithNegativeNum()
        {
            double math = -5;
            Assert.AreEqual(math, CalcSim("min(-5, 5)"));
        }

        [TestMethod]//29
        public void minWithNegativeNums()
        {
            double math = -7;
            Assert.AreEqual(math, CalcSim("min(-5, -7)"));
        }

        [TestMethod]//30
        public void minPlusNum()
        {
            double math = 7;
            Assert.AreEqual(math, CalcSim("5 + min(2, 3"));
        }

        [TestMethod]//31
        public void minMinusNum()
        {
            double math = 3;
            Assert.AreEqual(math, CalcSim("5 - min(2, 3"));
        }

        [TestMethod]//32
        public void minTimesNum()
        {
            double math = 10;
            Assert.AreEqual(math, CalcSim("5 * min(2, 3"));
        }

        [TestMethod]//33
        public void minDividedNum()
        {
            double math = 5;
            Assert.AreEqual(math, CalcSim("15 / min(3, 4"));
        }

        [TestMethod]//34
        public void minMinustoNeg()
        {
            double math = -2;
            Assert.AreEqual(math, CalcSim("3 - min(5, 44"));
        }

        /////////////////////////////////////////////////////////Testing Absolute Value Fxn////////////////////////////////////////


    }
}
