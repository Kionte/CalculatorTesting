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

        //TEST VARIABLE NUMBERS PI AND e
        [TestMethod]
        public void Test_PI_lower()
        {
            string input = "pi";
            double expected = Math.PI;
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_PI_upper()
        {
            string input = "PI";
            double expected = Math.PI;
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_e_lower()
        {
            string input = "e";
            double expected = Math.E;
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_e_upper()
        {
            string input = "E";
            double expected = Math.E;
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; }
            Assert.AreEqual(true, tf);
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
        
        [TestMethod]
        public void Test_div_zero_pos_no()//Should fail because it does not throw a divisible by zero error. It outputs infinity:(
        {
            string input = "20 / 0";
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_div_zero_pos_yes()//Should fail because it does not throw a divisible by zero error. It outputs infinity:(
        {
            string input = "(20) / 0";
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_div_zero_neg_no()//Should fail because it does not throw a divisible by zero error. It outputs infinity:(
        {
            string input = "-20 / 0";
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_div_zero_neg_yes()//Should fail because it does not throw a divisible by zero error. It outputs infinity:(
        {
            string input = "-(20) / 0";
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; }
            Assert.AreEqual(true, tf);
        }

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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);

        }
        [TestMethod]
        public void Test_Sin_Pos_No_Deg()
        {
            string input = "sin 1";
            double expected = Math.Sin(1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Sin_Neg_No_Rad()
        {
            string input = "sin -pi";
            double expected = Math.Sin((-1 * Math.PI));
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Cos_Pos_Par_Rad()
        {
            string input = "cos(pi)";
            double expected = Math.Cos(Math.PI);
            Assert.AreEqual(expected,CalcSim(input));
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Cos_Pos_No_Deg()
        {
            string input = "cos 1";
            double expected = Math.Cos(1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Cos_Neg_No_Deg()
        {
            string input = "cos -1";
            double expected = Math.Cos(-1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Tan_Pos_No_Deg()
        {
            string input = "tan 1";
            double expected = Math.Tan(1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Tan_Neg_No_Deg()
        {
            string input = "tan -1";
            double expected = Math.Tan(-1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_aSin_Pos_No_Deg()
        {
            string input = "asin 1";
            double expected = Math.Asin(1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_aSin_Neg_No_Rad()
        {
            string input = "asin -pi";
            double expected = Math.Asin((-1 * Math.PI));
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_aCos_Pos_No_Deg()
        {
            string input = "acos 1";
            double expected = Math.Acos(1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_aCos_Neg_No_Deg()
        {
            string input = "acos -1";
            double expected = Math.Acos(-1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Atan_Pos_No_Deg()
        {
            string input = "atan 1";
            double expected = Math.Atan(1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_aTan_Neg_Par_Rad()
        {
            string input = "atan(- pi)";
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_Atan_Neg_No_Deg()
        {
            string input = "atan -1";
            double expected = Math.Atan(-1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
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
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_ln_Pos_No_Rad()
        {
            string input = "ln pi";
            double expected = Math.Log(Math.PI);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_ln_Neg_Par_Deg()
        {
            string input = "ln(-1)";
            double expected = Math.Log(-1);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_ln_Neg_Par_Rad()
        {
            string input = "ln(-pi)";
            double expected = Math.Log(-1*Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_ln_Neg_No_Deg()
        {
            string input = "ln -1";
            double expected = Math.Log(-1);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_ln_Neg_No_Rad()
        {
            string input = "ln -pi";
            double expected = Math.Log(-1*Math.PI);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_log_Pos_Par_Deg()
        {
            string input = "log(10)";
            double expected = Math.Log10(10);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_log_Pos_Par_Rad()
        {
            string input = "log(pi)";
            double expected = Math.Log10(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_log_Pos_No_Deg()
        {
            string input = "log 10";
            double expected = Math.Log10(10);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_log_Pos_No_Rad()
        {
            string input = "log pi";
            double expected = Math.Log10(Math.PI);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_log_Neg_Par_Deg()
        {
            string input = "log(-10)";
            double expected = Math.Log10(-10);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_log_Neg_Par_Rad()
        {
            string input = "log(-pi)";
            double expected = Math.Log10(-1 * Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        [TestMethod]
        public void Test_log_Neg_No_Deg()
        {
            string input = "log -10";
            double expected = Math.Log10(-10);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_log_Neg_No_Rad()
        {
            string input = "log -pi";
            double expected = Math.Log10(-1 * Math.PI);
            bool tf = false;
            try
            {
                CalcSim(input);
            }
            catch (CalculatorException ex) { tf = true; Console.WriteLine(ex.Message); }
            Assert.AreEqual(true, tf);
        }
        [TestMethod]
        public void Test_sqrt_Par_Pos_Deg()
        {
            string input = "sqrt(4)";
            double expected = Math.Sqrt(4);
            Assert.AreEqual(expected, CalcSim(input));

        }
        public void Test_sqrt_Par_Pos_Rad()
        {
            string input = "sqrt(pi)";
            double expected = Math.Sqrt(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));

        }
        public void Test_sqrt_Par_Neg_Deg()
        {
            string input = "sqrt(-4)";
            double expected = Math.Sqrt(-4);
            Assert.AreEqual(expected, CalcSim(input));
        }
        public void Test_sqrt_Par_Neg_Rad()
        {
            string input = "sqrt(-pi)";
            double expected = Math.Sqrt(-1*Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        public void Test_sqrt_No_Pos_Deg()
        {
            string input = "sqrt 4";
            double expected = Math.Sqrt(4);
            Assert.AreEqual(expected, CalcSim(input));
        }
        public void Test_sqrt_No_Pos_Rad()
        {
            string input = "sqrt pi";
            double expected = Math.Sqrt(Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }
        public void Test_sqrt_No_Neg_Deg()
        {
            string input = "sqrt -4";
            double expected = Math.Sqrt(-4);
            Assert.AreEqual(expected, CalcSim(input));
        }
        public void Test_sqrt_No_Neg_Rad()
        {
            string input = "sqrt -pi";
            double expected = Math.Sqrt(-1*Math.PI);
            Assert.AreEqual(expected, CalcSim(input));
        }

    }
}
