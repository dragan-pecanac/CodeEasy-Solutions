/*Write a program that first waits for the user to input two integers, A and B, one after the other, from the console. 
Then the user should input the operation "add" or "multiply". If the user inputs "add", output the sum of A and B. 
If the user answers "multiply", output the multiplication product of A and B.*/
using System;
namespace Booleans
{
	public class ConsoleReadLine
	{
		public static void Main(string[] args)
		{
			string aString = Console.ReadLine();
			string bString = Console.ReadLine();
			int a = int.Parse(aString);
			int b = int.Parse(bString);
			string operation = Console.ReadLine();
			if (operation == "add")
			{
				Console.WriteLine(a + b);
			}
			if (operation == "mulitply")
			{
				Console.WriteLine(a * b);
            }
		}
	}
}