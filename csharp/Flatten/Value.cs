namespace Flatten;

public class Value : Node
{
    public Value(int value)
    {
        this.Val = value;
    }

    public int Val { get; }

    public override string ToString()
    {
        return String.Format("{0}", this.Val);
    }
}