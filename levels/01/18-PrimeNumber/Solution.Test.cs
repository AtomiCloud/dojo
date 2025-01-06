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
        List<object> actual = ["Prime","Prime","4","Prime","6","Prime","8","9","10","Prime","12","Prime","14","15","16","Prime","18","Prime","20","21","22","Prime","24","25","26","27","28","Prime","30","Prime","32","33","34","35","36","Prime","38","39","40","Prime","42","Prime","44","45","46","Prime","48","49"];
        Assert.Equal(actual, fake.Results);
    }
}