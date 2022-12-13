using System;
namespace ConsoleInput
{
    public class LargerNumber
    {
    	public static void Main(string[] args)
    	{
    		int firstValue = 5;
    		int secondValue = 6;
    		int largerValue;
    		if (firstValue > secondValue)
    		{
    			largerValue = firstValue;
    		}
    		else
    		{
    			largerValue = secondValue;
    		}
    		Console.WriteLine(largerValue);
    	}
	}
}