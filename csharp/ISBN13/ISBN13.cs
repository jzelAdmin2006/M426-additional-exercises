using System.Numerics;
using System.Globalization;
namespace ISBN13;

public class ISBN13
{
    public ISBN13(string isbn)
    {
        this.ISBN = isbn;
    }

    public string ISBN { get; }

    public bool IsValid()
    {
        if (this.ISBN.Length < 13)
        {
            return false;
        }
        if (this.ISBN.Length > 13)
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[0]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[1]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[2]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[3]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[4]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[5]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[6]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[7]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[8]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[9]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[10]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[11]))
        {
            return false;
        }
        if (!new List<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }.Contains(this.ISBN[12]))
        {
            return false;
        }
        if (((this.ISBN[0] - (int)'0')
            + 3 * (this.ISBN[1] - (int)'0')
            + (this.ISBN[2] - (int)'0')
            + 3 * (this.ISBN[3] - (int)'0')
            + (this.ISBN[4] - (int)'0')
            + 3 * (this.ISBN[5] - (int)'0')
            + (this.ISBN[6] - (int)'0')
            + 3 * (this.ISBN[7] - (int)'0')
            + (this.ISBN[8] - (int)'0')
            + 3 * (this.ISBN[9] - (int)'0')
            + (this.ISBN[10] - (int)'0')
            + 3 * (this.ISBN[11] - (int)'0')
            + (this.ISBN[12] - (int)'0')
        ) % 10 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
