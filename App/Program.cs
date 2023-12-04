namespace App;
public class Program
{
    public static string hello()
    {
        return "Hello, World!";
    }

    public static string secret()
    {
        return "ff";
    }
    static void Main(string[] args)
    {
        Console.WriteLine(hello());
    }
}
