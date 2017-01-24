using System;

namespace simple_calculator
{
	class MainClass
	{
		/*
		 * Build a simple calculator. Read in two integers from the user and add them together. Print the results
		 * in a nice output statement.
		 */

		public static void Main(string[] args)
		{
			Console.WriteLine("This is a simple calculator. If you want to '+', '-', '*', '/' you can");
			Console.WriteLine("Keep in mind if you want to divide enter the number you want to divide first followed by the divided by. \n");

			Console.WriteLine("Enter the first number.");
			int num1 = int.Parse(Console.ReadLine());

			Console.WriteLine("\n Now enter the operation ie. '+', '-', '*', '/'");
			char oper = char.Parse(Console.ReadLine());

			Console.WriteLine("\n Enter the second number");
			int num2 = int.Parse(Console.ReadLine());


			switch (oper)
			{
				case '+':
					{
						Console.WriteLine("Your answer is {0}", num1 + num2);
						break;
					}
				case '-':
					{
						Console.WriteLine("Your answer is {0}", num1 - num2);
						break;
					}
				case '*':
					{
						Console.WriteLine("Your answer is {0}", num1 * num2);
						break;
					}
				case '/':
					{
						Console.WriteLine("Your answer is {0}", num1 / num2);
						break;
					}
				default:
					{
						Console.WriteLine("That is not an operator used in this program");
						break;
					}
			}


		}
	}
}
