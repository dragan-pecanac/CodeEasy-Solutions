/*Write an adequacy checker program that passes judgment on a person based on the number of jokes the person tells. 
If the person tells less than 1 OR more than 10 jokes, your program should output "You are weird"; otherwise, it should output "You are funny." 
Submit with the number of jokes — 12.*/
using System;
namespace Booleans
{
  class PersonAdequacyChecker
  {
    static void Main(string[] args)
    {
      int numberOfJokes = 12;
      if(numberOfJokes > 10 || numberOfJokes < 1)
      {
        Console.WriteLine("You are weird");
      }
      else
      {
        Console.WriteLine("You are funny");
      }
    }
  }
}
