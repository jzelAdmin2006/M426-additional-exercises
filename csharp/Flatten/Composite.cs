namespace Flatten;

public class Composite
{
    public Composite()
    {
        this.Items = new List<Node>();
    }

    public List<Node> Items { get; }

    public void Add(Node item)
    {
        this.Items.Add(item);
    }

    public int[] Flatten()
    {
        throw new NotImplementedException("Flatten is not implemented yet");
    }

    public override string ToString()
    {
        return string.Join(", ", this.Items.Select((s) => s.ToString()));
    }
}