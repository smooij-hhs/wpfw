using App;

namespace Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.Equal("Steven", Environment.GetEnvironmentVariable("NOSECRET"));
        Assert.Equal("Hello, World!", Program.hello());
    }
}