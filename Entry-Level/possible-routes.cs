/*
From city A to city B there are 3 roads. And from city B to city C there are 4 roads. 
Write a program that calculates the number of possible routes from city A to city C, 
and if the number is more than 10, have your program output: 
"I can't check them all." Otherwise, have it output: "I can check them all."
*/
using System;
namespace Booleans
{
	class RoadsObserver
	{
		static void Main(string[] args)
		{
			int roadsFromAToB = 3;
			int roadsFromBToC = 4;
			int roadsFromAToC = roadsFromAToB * roadsFromBToC;
			if (roadsFromAToC > 10)
			{
				Console.WriteLine("I can't check them all.");
			}
			else
			{
				Console.WriteLine("I can check them all.");
			}
		}
	}
}