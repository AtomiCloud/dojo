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
        List<object> actual = ["1900","1901","1902","1903","Leap",
    "1905","1906","1907","Leap","1909","1910","1911","Leap",
    "1913","1914","1915","Leap","1917","1918","1919","Leap",
    "1921","1922","1923","Leap","1925","1926","1927","Leap",
    "1929","1930","1931","Leap","1933","1934","1935","Leap",
    "1937","1938","1939","Leap","1941","1942","1943","Leap",
    "1945","1946","1947","Leap","1949","1950","1951","Leap",
    "1953","1954","1955","Leap","1957","1958","1959","Leap",
    "1961","1962","1963","Leap","1965","1966","1967","Leap",
    "1969","1970","1971","Leap","1973","1974","1975","Leap",
    "1977","1978","1979","Leap","1981","1982","1983","Leap",
    "1985","1986","1987","Leap","1989","1990","1991","Leap",
    "1993","1994","1995","Leap","1997","1998","1999","Leap",
    "2001","2002","2003","Leap","2005","2006","2007","Leap",
    "2009","2010","2011","Leap","2013","2014","2015","Leap",
    "2017","2018","2019","Leap","2021","2022","2023","Leap",
    "2025","2026","2027","Leap","2029","2030","2031","Leap",
    "2033","2034","2035","Leap","2037","2038","2039","Leap",
    "2041","2042","2043","Leap","2045","2046","2047","Leap",
    "2049","2050","2051","Leap","2053","2054","2055","Leap",
    "2057","2058","2059","Leap","2061","2062","2063","Leap",
    "2065","2066","2067","Leap","2069","2070","2071","Leap",
    "2073","2074","2075","Leap","2077","2078","2079","Leap",
    "2081","2082","2083","Leap","2085","2086","2087","Leap",
    "2089","2090","2091","Leap","2093","2094","2095","Leap",
    "2097","2098","2099","2100"];
        Assert.Equal(actual, fake.Results);
    }
}