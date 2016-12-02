using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    // This class will contain test cases that will test if the program can handle non mathmatic values

    [TestClass]
    class ModifyPi
    {
        public double Calc(string expression)
        {
            Calculator calc = new Calculator();
            calc.Execute(expression);

            return calc.Answer;
        }

        [TestMethod]
        public void ModConstant_Pi()
        {
            bool a = true;
            try
            {
                Calc("pi = 1");

            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_E()
        {
            bool a = true;
            try
            {
                Calc("e = 1");
            }
            catch(Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_E_to_Pi()
        {
            bool a = true;
            try
            {
                Calc("e = pi");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_Pi__to_E()
        {
            bool a = true;
            try
            {
                Calc("pi = e");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_E_to_Err()
        {
            bool a = true;
            try
            {
                Calc("e = '");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_Pi_to_Err()
        {
            bool a = true;
            try
            {
                Calc("pi = '");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_Del_E()
        {
            bool a = true;
            try
            {
                Calc("delete e");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void ModConstant_Del_PI()
        {
            bool a = true;
            try
            {
                Calc("delete pi");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
    }
}
