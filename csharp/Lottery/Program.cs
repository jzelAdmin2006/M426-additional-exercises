namespace Lottery;

public class Program
{
    public static void Main()
    {
        var playerBudget = 100.0f;
        var betCost = 2.0f;
        var rewards = new Dictionary<int, float>(){
            {3, 5.0f},
            {4, 75.0f},
            {5, 25_000.0f},
            {6, 1_000_000.0f},
        };
        var lottery = new Lottery(45, 6);
        var round = 0;
        while (playerBudget > betCost)
        {
            var bet = lottery.CreateRandomBet();
            var draw = lottery.Draw();
            Console.WriteLine($"Player bet {string.Join(" ", bet)}, winning numbers: {string.Join(" ", draw.WinningNumbers)}");
            var correct = draw.CountCorrectNumbers(bet);
            var win = draw.GetReward(bet, rewards, betCost);
            Console.WriteLine($"{correct} correct numbers, player wins {win}.");
            playerBudget += win;
            round++;
        }
        Console.WriteLine($"Player is broke after {round} rounds.");
    }
}