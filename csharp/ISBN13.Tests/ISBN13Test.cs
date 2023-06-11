namespace ISBN13.Tests;

public class UnitTest1
{
    [Theory]
    [InlineData("9780134190440", true)]
    [InlineData("9780262510875", true)]
    [InlineData("9780262046305", true)]
    [InlineData("9780465026562", true)]
    [InlineData("9783518380635", true)]
    [InlineData("9780131103627", true)]
    [InlineData("9780262546379", true)]
    [InlineData("0134190440", false)]  // too short
    [InlineData("0000262510875", false)]  // wrong prefix
    [InlineData("9780262X46305", false)]  // X character in the middle
    [InlineData("9780460026562", false)]  // invalid checksum (messed up number)
    [InlineData("9783518380634", false)]  // invalid checksum (messed up checksum)
    public void TestValidISBN13(string raw, bool expected)
    {
        // Arrange
        var isbn13 = new ISBN13(raw);

        // Act
        var actual = isbn13.IsValid();

        // Assert
        Assert.Equal(expected, actual);
    }
}