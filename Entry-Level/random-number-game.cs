using System;
public static class diceGame
{
	public static void Main()
	{
		Random dice = new Random();
	int roll1 = dice.Next(1, 7);
	int roll2 = dice.Next(1, 7);
	int roll3 = dice.Next(1, 7);
	int total = roll1 + roll2 + roll3;
	Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
		if (total > 14)
		{
			Console.WriteLine("You win!");
		}
		else
		{
			Console.WriteLine("Sorry, you lose.");
		}
	}
}