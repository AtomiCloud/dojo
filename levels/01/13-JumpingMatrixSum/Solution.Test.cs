using Xunit;

interface Writer
{
    void WriteLine(string value);
    void WriteLine(int value);
    void WriteLine(long value);
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

    public void WriteLine(long value)
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
        List<object> actual = [3,6,9,12,15,18,9,18,27,36,45,54,15,30,45,60,75,90,21,42,63,84,105,126,27,54,81,108,135,162,33,66,99,132,165,198,39,78,117,156,195,234,45,90,135,180,225,270,51,102,153,204,255,306,57,114,171,228,285,342];
        Assert.Equal(actual, fake.Results);
    }
}