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
        List<object> actual = [91,24,161,34,231,44,301,54,371,7,12,17,22,27,32,37,42,47,117,26,207,36,297,46,387,56,477,5,10,15,20,25,30,35,40,45,143,28,253,38,363,48,473,58,583,3,8,13,18,23,28,33,38,43,169,30,299,40,429,50,559,60,689,1,6,11,16,21,26,31,36,41,195,32,345,42,495,52,645,62,795,1,4,9,14,19,24,29,34,39,221,34,391,44,561,54,731,64,901,3,2,7,12,17,22,27,32,37,247,36,437,46,627,56,817,66,1007,5,0,5,10,15,20,25,30,35,273,38,483,48,693,58,903,68,1113,7,2,3,8,13,18,23,28,33,299,40,529,50,759,60,989,70,1219,9,4,1,6,11,16,21,26,31,325,42,575,52,825,62,1075,72,1325,11,6,1,4,9,14,19,24,29,351,44,621,54,891,64,1161,74,1431,13,8,3,2,7,12,17,22,27,377,46,667,56,957,66,1247,76,1537,15,10,5,0,5,10,15,20,25,403,48,713,58,1023,68,1333,78,1643,17,12,7,2,3,8,13,18,23,429,50,759,60,1089,70,1419,80,1749,19,14,9,4,1,6,11,16,21,51250];
        Assert.Equal(actual, fake.Results);
    }
}