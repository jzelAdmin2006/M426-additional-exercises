namespace Lottery;

public class LotteryDraw
{
    public LotteryDraw(List<int> winningNumbers)
    {
        this.WinningNumbers = winningNumbers;
    }

    public List<int> WinningNumbers { get; }

    public int CountCorrectNumbers(List<int> bet)
    {
        // TODO: Count numbers in bet that are also in WinningNumbers.
        return -1;
    }

    public float GetReward(List<int> bet, Dictionary<int, float> rewards, float betCost)
    {
        // TODO: Count correct numbers and look up the reward in rewards.
        // If a reward is found, return the amount (player wins) minus the bet_cost.
        // If no reward is found, return the bet_cost as a negative value (player looses).
        return 0.0f;
    }
}