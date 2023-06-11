namespace RockPaperScissors.Tests;

public class RockPaperScissorsTest
{
    [Theory]
    [InlineData("rock", "rock", 0)]
    [InlineData("paper", "paper", 0)]
    [InlineData("scissors", "scissors", 0)]
    [InlineData("rock", "scissors", -1)]
    [InlineData("scissors", "rock", 1)]
    [InlineData("paper", "rock", -1)]
    [InlineData("rock", "paper", 1)]
    [InlineData("scissors", "paper", -1)]
    [InlineData("paper", "scissors", 1)]
    public void TestWinner(string playerOne, string playerTwo, int expectedWinner)
    {
        // Arrange
        var game = new RockPaperScissors(playerOne, playerTwo);

        // Act
        var actualWinner = game.Winner();

        // Assert
        Assert.Equal(expectedWinner, actualWinner);
    }

    [Theory]
    [InlineData("", "")]
    [InlineData("ROCK", "paper")]
    [InlineData(" rock ", "paper")]
    [InlineData("sceezors", "rock")]
    [InlineData("scissors", "rocc")]
    [InlineData("paypa", "scissors")]
    [InlineData("paper", "5c1550r5")]
    public void TestValidation(string playerOne, string playerTwo)
    {
        Assert.Throws<ArgumentException>(() => new RockPaperScissors(playerOne, playerTwo));
    }
}