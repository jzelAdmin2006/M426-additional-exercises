namespace Flatten;

public class Program
{
    public static void Main()
    {
        var numbers = new Composite();
        numbers.Add(new Value(0));
        numbers.Add(new List(new Node[] {
            new Value(1),
            new Value(2),
            new Value(3),
        }));
        numbers.Add(new Value(4));
        numbers.Add(new List(new Node[] {
            new Value(5),
            new List(new Node[]{
                new Value(6),
                new List(new Node[] {
                    new Value(7),
                }),
            }),
            new Value(8),
        }));
        numbers.Add(new List(new Node[]{
            new Value(9)
        }));
        Console.WriteLine(numbers);
        Console.WriteLine(numbers.Flatten());
    }
}
