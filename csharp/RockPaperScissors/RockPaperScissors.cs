using System.Xml.Schema;
using System.ComponentModel.DataAnnotations;
namespace RockPaperScissors;

public class RockPaperScissors
{
    public RockPaperScissors(string playerOne, string playerTwo)
    {
        var valid = new List<string>() { "rock", "paper", "scissors" };
        if (!valid.Contains(playerOne))
        {
            throw new ArgumentException($"invalid move {playerOne}");
        }
        if (!valid.Contains(playerTwo))
        {
            throw new ArgumentException($"invalid move {playerTwo}");
        }
        this.PlayerOne = playerOne;
        this.PlayerTwo = playerTwo;
    }

    public string PlayerOne { get; }
    public string PlayerTwo { get; }

    public int Winner()
    {
        if (this.PlayerOne.Equals(this.PlayerTwo))
        {
            return 0;
        }
        if (this.PlayerOne.Equals("rock") && this.PlayerTwo.Equals("scissors"))
        {
            return -1;
        }
        if (this.PlayerOne.Equals("scissors") && this.PlayerTwo.Equals("rock"))
        {
            return 1;
        }
        if (this.PlayerOne.Equals("paper") && this.PlayerTwo.Equals("rock"))
        {
            return -1;
        }
        if (this.PlayerOne.Equals("rock") && this.PlayerTwo.Equals("paper"))
        {
            return 1;
        }
        if (this.PlayerOne.Equals("scissors") && this.PlayerTwo.Equals("paper"))
        {
            return -1;
        }
        if (this.PlayerOne.Equals("paper") && this.PlayerTwo.Equals("scissors"))
        {
            return 1;
        }
        throw new ArgumentException($"{this.PlayerOne}:{this.PlayerTwo} is undefined");
    }
}
