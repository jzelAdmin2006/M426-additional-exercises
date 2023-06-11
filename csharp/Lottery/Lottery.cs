namespace Lottery
{
    public class Lottery
    {
        public Lottery(int maxNumber, int drawSize)
        {
            this.MinNumber = 1;
            this.MaxNumber = maxNumber;
            this.DrawSize = drawSize;
        }

        public int MinNumber { get; }
        public int MaxNumber { get; }
        public int DrawSize { get; }

        public LotteryDraw Draw()
        {
            // TODO: Draw draw_size random numbers from min_number to max_number.
            return new LotteryDraw(new List<int>() { });
        }

        public List<int> CreateRandomBet()
        {
            // TODO: Return DrawSize random numbers from MinNumber to MaxNumber.
            return new List<int>();
        }
    }
}