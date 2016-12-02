using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleCalculator
{
    // This class will contain test cases that test outside the limits of the program it should fail but be able to catrch and handle the excpetions

    [TestClass]
    public class Parser
    {
        public double Calc(string expression)
        {
            Calculator calc = new Calculator();
            calc.Execute(expression);

            return calc.Answer;
        }
        public void Delete_Non_Var()
        {
            bool a = true;
            try
            {
                Calc("delete a");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
        public void Change_Val_Of_Non_var()
        {
            bool a = true;
            try
            {
                Calc("a + 1");
            }
            catch (Exception e)
            {
                a = false;
            }
            Assert.AreEqual(false, a);
        }
    }
}
