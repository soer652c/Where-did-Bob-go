public class Hint
{
    public string Help { get; }
    public string Message { get; }

    public Hint(string help, string message) 
    {
        Help = help;
        message = message;
    }

    public void Speak()
    {
        console.WriteLine("You need help?")
    }
}