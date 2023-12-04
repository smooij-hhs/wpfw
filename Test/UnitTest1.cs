using App;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Console.WriteLine("C# env: " + Environment.GetEnvironmentVariable("vars.NOSECRET"));
        Assert.Equal("Hello, World!", Program.hello());
    }
}