using System.Data;

namespace Flatten;

public class List : Node
{
    public List(Node[] items)
    {
        this.Items = items;
    }

    public Node[] Items { get; }

    public override string ToString()
    {
        return "[" + string.Join(", ", this.Items.Select((s) => s.ToString())) + "]";
    }
}