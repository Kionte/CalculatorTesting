using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;


namespace ConsoleCalculator
{
    [TestClass]
    public class Test_calcExecute
    {

        public double CalcSim(string input)//This string is what will be sent to the calculator to be evaluated. ex 2 + 2
        {
            Calculator calc = new Calculator();//Sets up calculator and sends the input string to the calculator to execute. 
            calc.Execute(input);
           
                return calc.Answer;//Returns the answer double from the evaluated expression.
        }

        public void something()
        {
            
        }

        //BASIC TWO VAR INPUTS 
        [TestMethod]//Write tests as Test_[Function]_[Cond1]_[Cond2]
        public void Test_add_pos_pos()
        {
            double math = 20 + 20;//does the math to be checked.
            Assert.AreEqual(math, CalcSim("20 + 20"));//Runs the calculator with the expression string within the parenthese.
        }

        [TestMethod]
        public void Test_add_neg_neg()
        {
            double math = -20 + -20;
            Assert.AreEqual(math, CalcSim("-20 + -20"));
        }

        [TestMethod]
        public void Test_add_pos_neg()
        {
            double math = 20 + -20;
            Assert.AreEqual(math, CalcSim("20 + -20"));
        }

        [TestMethod]
        public void Test_add_neg_pos()
        {
            double math = -20 + 20;
            Assert.AreEqual(math, CalcSim("-20 + 20"));
        }

        [TestMethod]
        public void Test_sub_pos_pos()
        {
            double math = 20 - 20;
            Assert.AreEqual(math, CalcSim("20 - 20"));
        }

        [TestMethod]
        public void Test_sub_pos_neg()
        {
            double math = 20 - -20;
            Assert.AreEqual(math, CalcSim("20 - -20"));
        }

        [TestMethod]
        public void Test_sub_neg_pos()
        {
            double math = -20 - 20;
            Assert.AreEqual(math, CalcSim("-20 - 20"));
        }
        [TestMethod]
        public void Test_sub_neg_neg()
        {
            double math = -20 - -20;
            Assert.AreEqual(math, CalcSim("-20 - -20"));
        }

        [TestMethod]
        public void Test_div_pos_pos()
        {
            double math = 20 / 20;
            Assert.AreEqual(math, CalcSim("20 / 20"));
        }

        [TestMethod]
        public void Test_div_pos_neg()
        {
            double math = 20 / -20;
            Assert.AreEqual(math, CalcSim("20 / -20"));
        }

        [TestMethod]
        public void Test_div_neg_pos()
        {
            double math = -20 / 20;
            Assert.AreEqual(math, CalcSim("-20 / 20"));
        }
        [TestMethod]
        public void Test_div_neg_neg()
        {
            double math = -20 / -20;
            Assert.AreEqual(math, CalcSim("-20 / -20"));
        }
        [TestMethod]
        public void Test_mult_pos_pos()
        {
            double math = 20 * 20;
            Assert.AreEqual(math, CalcSim("20 * 20"));
        }
        [TestMethod]
        public void Test_mult_pos_neg()
        {
            double math = 20 * -20;
            Assert.AreEqual(math, CalcSim("20 * -20"));
        }
        [TestMethod]
        public void Test_mult_neg_pos()
        {
            double math = -20 * 20;
            Assert.AreEqual(math, CalcSim("-20 * 20"));
        }
        [TestMethod]
        public void Test_mult_neg_neg()
        {
            double math = -20 * -20;
            Assert.AreEqual(math, CalcSim("-20 * -20"));
        }
        /*
        [TestMethod]
        public void Test_div_zero()
        {
            //Cannot test in this Test class. Need a way to check if the calculator registered a error for Robust boundary testing
            Calculator calc = new Calculator();
            
            Assert.IsFalse(calc.Execute("20 / 0"));
        }
        */
       //TRIG FUNCTION TESTS
       [TestMethod]
       public void Test_Sin_Pos_Par_Rad()
        {
            string input = "sin(pi)";
            double expected = Math.Sin(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }

        [TestMethod]
        public void Test_Sin_Pos_Par_Deg()
        {
            string input = "sin(1)";
            double expected = Math.Sin(1);
            Assert.AreEqual(expected, CalcSim(input));
        }

        [TestMethod]
        public void Test_Sin_Pos_No_Rad()
        {
            string input = "sin pi";
            double expected = Math.Sin(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Sin_Pos_No_Deg()
        {
            string input = "sin 1";
            double expected = Math.Sin(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Sin_Neg_Par_Rad()
        {
            string input = "sin(-pi)";
            double expected = Math.Sin((-1 * Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Sin_Neg_Par_Deg()
        {
            string input = "sin(-1)";
            double expected = Math.Sin((-1));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Sin_Neg_No_Deg()
        {
            string input = "sin -1";
            double expected = Math.Sin((-1));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Sin_Neg_No_Rad()
        {
            string input = "sin -pi";
            double expected = Math.Sin((-1 * Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Pos_Par_Rad()
        {
            string input = "cos(pi)";
            double expected = Math.Cos(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Pos_Par_Deg()
        {
            string input = "cos(1)";
            double expected = Math.Cos(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Pos_No_Rad()
        {
            string input = "cos pi ";
            double expected = Math.Cos(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Pos_No_Deg()
        {
            string input = "cos 1";
            double expected = Math.Cos(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Neg_Par_Rad()
        {
            string input = "cos(-pi)";
            double expected = Math.Cos(-1*(Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Neg_Par_Deg()
        {
            string input = "cos(-1)";
            double expected = Math.Cos(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Neg_No_Rad()
        {
            string input = "cos -pi";
            double expected = Math.Cos(-1*(Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Cos_Neg_No_Deg()
        {
            string input = "cos -1";
            double expected = Math.Cos(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Pos_Par_Rad()
        {
            string input = "tan(pi)";
            double expected = Math.Tan(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Pos_Par_Deg()
        {
            string input = "tan(1)";
            double expected = Math.Tan(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Pos_No_Rad()
        {
            string input = "tan pi";
            double expected = Math.Tan(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Pos_No_Deg()
        {
            string input = "tan 1";
            double expected = Math.Tan(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Neg_Par_Rad()
        {
            string input = "tan(-pi)";
            double expected = Math.Tan(-1*(Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Neg_Par_deg()
        {
            string input = "tan(-1)";
            double expected = Math.Tan(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Neg_No_Rad()
        {
            string input = "tan -pi";
            double expected = Math.Tan(-1 * (Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Tan_Neg_No_Deg()
        {
            string input = "tan -1";
            double expected = Math.Tan(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        //TRIG FUNCTION TESTS
        [TestMethod]
        public void Test_aSin_Pos_Par_Rad()
        {
            string input = "asin(pi)";
            double expected = Math.Asin(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }

        [TestMethod]
        public void Test_aSin_Pos_Par_Deg()
        {
            string input = "asin(1)";
            double expected = Math.Asin(1);
            Assert.AreEqual(expected, CalcSim(input));
        }

        [TestMethod]
        public void Test_ASin_Pos_No_Rad()
        {
            string input = "asin pi";
            double expected = Math.Asin(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aSin_Pos_No_Deg()
        {
            string input = "asin 1";
            double expected = Math.Asin(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aSin_Neg_Par_Rad()
        {
            string input = "asin(-pi)";
            double expected = Math.Asin((-1 * Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aSin_Neg_Par_Deg()
        {
            string input = "asin(-1)";
            double expected = Math.Asin((-1));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aSin_Neg_No_Deg()
        {
            string input = "asin -1";
            double expected = Math.Asin((-1));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aSin_Neg_No_Rad()
        {
            string input = "asin -pi";
            double expected = Math.Asin((-1 * Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Pos_Par_Rad()
        {
            string input = "acos(pi)";
            double expected = Math.Acos(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Pos_Par_Deg()
        {
            string input = "acos(1)";
            double expected = Math.Acos(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Pos_No_Rad()
        {
            string input = "acos pi ";
            double expected = Math.Acos(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Pos_No_Deg()
        {
            string input = "acos 1";
            double expected = Math.Acos(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Neg_Par_Rad()
        {
            string input = "acos(-pi)";
            double expected = Math.Acos(-1 * (Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Neg_Par_Deg()
        {
            string input = "acos(-1)";
            double expected = Math.Acos(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Neg_No_Rad()
        {
            string input = "acos -pi";
            double expected = Math.Acos(-1 * (Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aCos_Neg_No_Deg()
        {
            string input = "acos -1";
            double expected = Math.Acos(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aTan_Pos_Par_Rad()
        {
            string input = "atan(pi)";
            double expected = Math.Atan(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aTan_Pos_Par_Deg()
        {
            string input = "atan(1)";
            double expected = Math.Atan(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aTan_Pos_No_Rad()
        {
            string input = "atan pi";
            double expected = Math.Atan(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Atan_Pos_No_Deg()
        {
            string input = "atan 1";
            double expected = Math.Atan(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aTan_Neg_Par_Rad()
        {
            string input = "atan(-pi)";
            double expected = Math.Atan(-1 * (Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aTan_Neg_Par_deg()
        {
            string input = "atan(-1)";
            double expected = Math.Atan(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_aTan_Neg_No_Rad()
        {
            string input = "atan -pi";
            double expected = Math.Atan(-1 * (Math.PI));
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_Atan_Neg_No_Deg()
        {
            string input = "atan -1";
            double expected = Math.Atan(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        //Regular Functions
        [TestMethod]
        public void Test_ln_Pos_Par_Deg()
        {
            string input = "ln(1)";
            double expected = Math.Log(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_ln_Pos_Par_Rad()
        {
            string input = "ln(pi)";
            double expected = Math.Log(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_ln_Pos_No_Deg()
        {
            string input = "ln 1";
            double expected = Math.Log(1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_ln_Pos_No_Rad()
        {
            string input = "ln pi";
            double expected = Math.Log(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }

    }
}
