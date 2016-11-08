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

        [TestMethod]
        public void characters()
        {
            bool ex = false;
            try
            {
                CalcSim("b + c");
            }
            catch(CalculatorException e)
            {          
                ex = true;
                Console.WriteLine(e.ToString());
            }
            Assert.AreEqual(ex, true); //Assert.x (expected, tested) 
            //made true because that means the exception was thrown 
        }

        [TestMethod]
        public void CharactersWithSpaces()
        {
            bool ex = false;
            try
            {
                CalcSim("b c");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);  
        }


        [TestMethod]
        public void CharacterPlusNum()
        {
            bool ex = false;
            try
            {
                CalcSim("b + 1");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]
        public void CharacterMinusNum()
        {
            bool ex = false;
            try
            {
                CalcSim("b - 1");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]
        public void CharacterTimesNum()
        {
            bool ex = false;
            try
            {
                CalcSim("b * 1");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]
        public void CharacterDivNum()
        {
            bool ex = false;
            try
            {
                CalcSim("b / 1");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]
        public void NumWithSpaces()
        {
            bool ex = false;
            try
            {
                CalcSim("5  5");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//8
        public void CharacterAssigningVariableaandAdd()
        {
            bool ex = false;
            try
            {
                CalcSim("b = 1");
                CalcSim("b + 5");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, false);
        }

        [TestMethod]
        public void CharacterInitialized()
        {
            bool ex = false;
            try
            {
                CalcSim("b = 1");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, false);
        }

        [TestMethod]//10
        public void CharacterInitializedToChar()
        {
            bool ex = false;
            try
            {
                CalcSim("b = c");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }


        [TestMethod]//11
        public void CharacterSpaceBracket()
        {
            bool ex = false;
            try
            {
                CalcSim("b [");
            }
            catch
            { 
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }


        [TestMethod]//12
        public void CharacteragdNum()
        {
            bool ex = false;
            try
            {
                CalcSim("b4c");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//13
        public void CharacterNegative()
        {
            bool ex = false;
            try
            {
                CalcSim("-b");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//14
        public void CharacterPositive()
        {
            bool ex = false;
            try
            {
                CalcSim("+b");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }
        [TestMethod]//15
        public void CharacterEquals()
        {
            bool ex = false;
            try
            {
                CalcSim("=c");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//16
        public void IntEqual()
        {
            bool ex = false;
            try
            {
                CalcSim("=4");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }

        [TestMethod]//17
        public void IntSpaces()
        {
            bool ex = false;
            try
            {
                CalcSim("1    4");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }
        [TestMethod]//18
        public void CharacterAddingAssignedChars()
        {
            bool ex = false;
            try
            {
                CalcSim("b = 2");
                CalcSim("a = 3");
                CalcSim("a + b");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, false);
        }

        [TestMethod]//19
        public void CharacterPlusAscii()
        {
            bool ex = false;
            try
            {
                CalcSim("b + ∞");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }
        [TestMethod]//20
        public void CharacterWithAcent()
        {
            bool ex = false;
            try
            {
                CalcSim("à  +1");
            }
            catch
            {
                ex = true;
            }
            Assert.AreEqual(ex, true);
        }
    }
}
