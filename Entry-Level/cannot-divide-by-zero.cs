/*Your program should read two integers each from the prompt. Then, it should output the sum, difference, product, and quotient of those numbers. 
If the second number is zero, the program should output the sum, the difference, and the product, but instead of the quotient, it should print "Can't divide by zero!"*/
using System;
namespace OpenAdvancedInfo
{
	class MathOperations
	{
		static void Main(string[] args)
		{
			string firstNumberString = Console.ReadLine();
            string secondNumberString = Console.ReadLine();
            int firstNumber = int.Parse(firstNumberString);
            int secondNumber = int.Parse(secondNumberString);
            if (secondNumber != 0)
            {
                Console.WriteLine(firstNumber + secondNumber);
                Console.WriteLine(firstNumber - secondNumber);
                Console.WriteLine(firstNumber * secondNumber);
                Console.WriteLine(firstNumber / secondNumber);
            }
            if (secondNumber == 0)
            {
                Console.WriteLine(firstNumber + secondNumber);
                Console.WriteLine(firstNumber - secondNumber);
                Console.WriteLine(firstNumber * secondNumber);
                Console.WriteLine("Can't divide by zero!");
            }
		}
	}
}