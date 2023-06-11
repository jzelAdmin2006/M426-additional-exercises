namespace Flatten.Tests;

public class UnitTest1
{
    [Fact]
    public void TestFlattenEmptyComposite()
    {
        // Arrange
        var numbers = new Composite();
        var expected = new int[] { };

        // Act
        var actual = numbers.Flatten();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestFlattenValuesOnly()
    {
        // Arrange
        var numbers = new Composite();
        numbers.Add(new Value(0));
        numbers.Add(new Value(1));
        numbers.Add(new Value(2));
        var expected = new int[] { 0, 1, 2 };

        // Act
        var actual = numbers.Flatten();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestFlattenListOfValues()
    {
        // Arrange
        var numbers = new Composite();
        numbers.Add(new List(new Node[] { new Value(1), new Value(2), new Value(3) }));
        numbers.Add(new List(new Node[] { new Value(4), new Value(5), new Value(6) }));
        numbers.Add(new List(new Node[] { new Value(7), new Value(8), new Value(9) }));
        var expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        var actual = numbers.Flatten();

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestFlattenNestedListsAndValues()
    {
        // Arrange
        var numbers = new Composite();
        numbers.Add(new Value(0));
        numbers.Add(new List(new Node[] {
            new Value(1),
            new Value(2),
            new Value(3),
        }));
        numbers.Add(new Value(4));
        numbers.Add(new List(new Node[]{
            new Value(5),
            new List(new Node[] {
                new Value(6),
                new List(new Node[] {
                    new Value(7),
                }),
            }),
        }));
        numbers.Add(new Value(8));
        numbers.Add(new List(new Node[] {
            new Value(9),
        }));
        var expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Act
        var actual = numbers.Flatten();

        // Assert
        Assert.Equal(expected, actual);
    }
}