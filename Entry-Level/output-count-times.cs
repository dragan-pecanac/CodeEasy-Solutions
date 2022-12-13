/*Write a program that reads an integer number called count from the console, and then output the message "I know where you live." to the screen count times.*/
using System;
namespace ForLoops
{
    class IKnowWhereYouLive
    {
        static void Main(string[] args)
        {
            string count = Console.ReadLine();
            int countTimes = int.Parse(count);
            for(int i = 0; i < countTimes; i++)
            {
                Console.WriteLine("I know where you live.");
            }
        }
    }
}