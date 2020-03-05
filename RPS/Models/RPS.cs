using System;

namespace RPS.Models
{
  public class Round
  {
    public string Player1Option { get; set; }
    public string Player2Option { get; set; }

    public Round(string optionP1, string optionP2) 
    {
      Player1Option = optionP1;
      Player2Option = optionP2;
    }
    public string Match()
    {
      if (Player1Option == Player2Option)
      {
        return "DRAW";
      }
      else if ((Player1Option == "scissors" && Player2Option == "paper") || (Player1Option == "paper" && Player2Option == "rock") || (Player1Option == "rock" && Player2Option == "scissors"))
      {
        return "Player1 Wins!";
      }
      else
      {
        return "Player2 Wins!";
      }
    }
  }
}