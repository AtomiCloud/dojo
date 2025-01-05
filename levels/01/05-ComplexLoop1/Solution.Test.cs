using Xunit;

interface Writer
{
    void WriteLine(string value);
    void WriteLine(int value);
    void WriteLine(bool value);
    void WriteLine(char value);
    void WriteLine(double value);
    void WriteLine(float value);
}


public class SpyWriter : Writer
{
    public readonly List<object> Results = [];
    public void WriteLine(string value)
    {
        Results.Add(value);
        Console.WriteLine(value);
    }

    public void WriteLine(int value)
    {
        Results.Add(value);
        Console.WriteLine(value);
    }

    public void WriteLine(bool value)
    {
        Results.Add(value);
        Console.WriteLine(value);
    }

    public void WriteLine(char value)
    {
        Results.Add(value);
        Console.WriteLine(value);
    }

    public void WriteLine(double value)
    {
        Results.Add(value);
        Console.WriteLine(value);
    }

    public void WriteLine(float value)
    {
        Results.Add(value);
        Console.WriteLine(value);
    }
}

public class Tester
{
    [Fact]
    public void FizzBuzzTest()
    {
        var fake = new SpyWriter();
        Solution.Start(fake);
        List<object> actual = [125, 12, 343, 16, 729, 20, 24, 2197, 28, 3375, 32, 4913, 36, 6859, 40, 9261, 12167, 48, 15625, 52, 19683, 56, 24389, 30, 31, 32, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 45, 46, 47, 48, 49, 50, 132651, 104, 148877, 108, 112, 185193, 116, 205379, 120, 226981, 124, 250047, 128, 274625, 300763, 136, 328509, 69, 357911, 71, 389017, 73, 421875, 75, 77, 493039, 79, 531441, 81, 571787, 83, 614125, 85, 658503, 704969, 89, 753571, 91, 804357, 93, 857375, 95, 912673, 97, 99, 1030301, 101, 1092727, 103, 1157625, 105, 1225043, 107, 1295029, 1367631, 111, 1442897, 113, 1520875, 115, 1601613, 117, 1685159, 119];
        Assert.Equal(actual, fake.Results);
    }
}