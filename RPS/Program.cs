using System;
using RPS.Models;

namespace RPS
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Player1 pick [rock], [paper], or [scissors]");
      string optionP1 = Console.ReadLine();
      Console.WriteLine("Player2 pick [rock], [paper], or [scissors]");
      string optionP2 = Console.ReadLine();

      Round newRound = new Round(optionP1, optionP2);
      Console.WriteLine(newRound.Match());
    }
  }
}