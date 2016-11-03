using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleCalculator {
	class Program {
		public void Run() {
			Calculator calc = new Calculator();
			Console.Title = "Console Calculator (C)2010 Pavel Yosifovich";

			Console.WriteLine("Simple calculator, by Pavel Yosifovich (C)2010");
			Console.WriteLine();
			do {
				try {
					Console.Write(">> ");
					string input = Console.ReadLine();
					if(string.IsNullOrEmpty(input))
						continue;
					if(input == "help" || input == "?") {
						Console.WriteLine("Available functions: ");
						foreach(var fun in calc.Functions)
							Console.Write("{0,8}", fun);
						Console.WriteLine();
						continue;
					}
					bool result = calc.Execute(input);
					if(result)
						Console.WriteLine("ans = {0}", calc.Answer);
					else
						Console.WriteLine("Ok.");
				}
				catch(CalculatorException ex) {
					Console.WriteLine(ex.Message);
				}
				Console.WriteLine();
			} while(true);
		}

        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Run();
        }
	}
}
