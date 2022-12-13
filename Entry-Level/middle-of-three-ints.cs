using System;
namespace ConsoleInput
{
    public class TheMiddle
    {
        public static void Main(string[] args)
        {
            string aString = Console.ReadLine();
            string bString = Console.ReadLine();
            string cString = Console.ReadLine();
            int a = int.Parse(aString);
            int b = int.Parse(bString);
            int c = int.Parse(cString);
            if ((a < b && b < c) || (c < b && b < a))
            {
                Console.WriteLine(b);
            }
            else if ((b < a && a < c) || (c < a && a < b))
            {    
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
    }
}