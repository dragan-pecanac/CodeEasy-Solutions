/*Write a program that saves the virus to the internal storage if it is not activated and if it costs more than 15. 
Submit with not activated virus with cost 20.*/
using System;
namespace Booleans
{
    public class VirusesStorage
    {
        public static void Main(String[] args)
        {
            bool virusIsActivated = false;
            int virusCost = 20;
            if(!virusIsActivated && virusCost > 15)
            {
                Console.WriteLine("Save to internal storage.");
            }
            else
            {
                Console.WriteLine("Throw away.");
            }
        }
    }
}