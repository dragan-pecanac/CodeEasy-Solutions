/*You have a cargo drone that can carry no more than 30 kg. For stability in flight, each box must be identical in weight. 
The user inputs the number of boxes to carry and then the weight of each. Compute the overall weight and output "Yes" 
if the weight is less than 30 kg. Otherwise, output "No".*/
using System;
namespace ConsoleInput
{
    public class WeightChecker
    {
        public static void Main(string[] args)
        {
            string numberOfBoxesString = Console.ReadLine();
            string weightString = Console.ReadLine();
            int numberOfBoxes = int.Parse(numberOfBoxesString);
            int weight = int.Parse(weightString);
            if (numberOfBoxes * weight < 30)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}