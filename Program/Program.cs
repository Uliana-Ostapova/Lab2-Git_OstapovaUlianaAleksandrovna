namespace Program;

class Program
{
    static void Main(string[] args)
    {
        console.WriteLine("Enter you name:");
        string? name = Console.Readline();
        console.WriteLine($"Hello, {name}");
    }
}