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
