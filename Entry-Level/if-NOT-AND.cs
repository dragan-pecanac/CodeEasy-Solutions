/*Noname consists of 6 modules. Sometimes an officious virus adds itself as a 7th module. 
We also know that this usually happens at night. Write a program that outputs ‘Connect to Noname.’ 
only if it is NOT night and the number of Noname's modules is equal to 6.*/
using System;
namespace Booleans
{
    public class FixNoname
    {
        public static void Main(string[] args)
        {
            bool isNight = false;
            int numberOfModules = 6;
            if(!isNight && numberOfModules == 6)
            {
                Console.WriteLine("Connect to Noname.");
            }
        }
    }
}