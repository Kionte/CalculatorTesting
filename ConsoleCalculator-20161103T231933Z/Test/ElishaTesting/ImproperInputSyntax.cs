using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    [TestClass]
    public class ImproperInputSyntax
    {
        
        public double CalcSim(string input)//This string is what will be sent to the calculator to be evaluated. ex 2 + 2
        {
            Calculator calc = new Calculator();//Sets up calculator and sends the input string to the calculator to execute. 
            calc.Execute(input);
            return calc.Answer;//Returns the answer double from the evaluated expression.
        }

       
        public string ScannerEX()
        {                           //getting access to the scanner exception
            CalculatorException ex = new CalculatorException();
            return ex.Message.ToString();

        }

        [TestMethod]
        public void characters()
        {

            Assert.AreEqual(ScannerEX(), CalcSim("b +c ")); //Assert.x (expected, tested) 
        }

        //[TestMethod]
        //public void spacesBetweenCharacters()
        //{

        //}

    }
}
