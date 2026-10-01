namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter you name:");
        string? name = Console.Readline();
        Console.WriteLine($"Hello, {name}");
        Console.WriteLine("How are you?");
        Console.WriteLine(1+1);
    }
}