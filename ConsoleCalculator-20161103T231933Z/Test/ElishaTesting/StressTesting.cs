using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    [TestClass]
    public class StressTesting
    {

        public double CalcSim(string input)//This string is what will be sent to the calculator to be evaluated. ex 2 + 2
        {
            Calculator calc = new Calculator();//Sets up calculator and sends the input string to the calculator to execute. 
            calc.Execute(input);
            return calc.Answer;//Returns the answer double from the evaluated expression.
        }

        [TestMethod]
        public void infinateLoopSimulation()
        {
            bool ex = true;
            try
            {
                for (int i = 0; ; i++)
                    CalcSim("b + c");
            }
            catch (CalculatorException e)
            {
                ex = true;
                Console.WriteLine(e.ToString());
            }
            Assert.AreEqual(ex, true); //Assert.x (expected, tested) 
            //made true because that means the exception was thrown 
        }

        [TestMethod]
        public void TangantConstant()
        {
            bool a = true;
            try
            {
                CalcSim("tan = 1");

            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);

        }

        [TestMethod]
        public void SineConstant()
        {
            bool a = true;
            try
            {
                CalcSim("sin = 1");

            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);

        }

        [TestMethod]
        public void CosineConstant()
        {
            bool a = true;
            try
            {
                CalcSim("cos = 1");

            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);

        }
    }

}