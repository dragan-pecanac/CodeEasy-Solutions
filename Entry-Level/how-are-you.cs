/*Write a program that asks the user how they are doing by using the phrase "How are you?" 
If the user answers "fine", respond with "Life is great!" 
Otherwise, try to cheer them up - respond with "Everything's gonna be alright."*/
using System;
namespace ConsoleInput
{
	public class MoodChecker
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("How are you?");
			string mood = Console.ReadLine();
			if (mood == "fine")
			{
				Console.WriteLine("Life is great!");
			}
			else
			{
				Console.WriteLine("Everything's gonna be alright.");
			}
		}
	}
}