/*Write a program that asks the user for their name using the phrase "Input your name, please." 
The program should then respond with "My greetings, {name}!"*/
using System;

namespace ConsoleRead
{
    public class Greeting
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Input your name, please.");
            string name = Console.ReadLine();
            Console.WriteLine($"My greetings, {name}!");
        }
    }
}