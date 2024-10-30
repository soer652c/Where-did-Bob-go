public class Hint
{
    public string Help { get; }
    public string Message { get; }

    public Hint(string help, string message)
    {
        Help = help;
        Message = message; // Assigning the parameter to the Message property
    }

    public void Speak()
    {
        Console.WriteLine("You need help?");
    }
}