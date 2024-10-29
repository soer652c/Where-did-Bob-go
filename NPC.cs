namespace DefaultNamespace;

public class NPC
{
    public string Place;
    public Dialog_Tree;
    public bool Visibility;
    public string Warningsigns = new warningsigns;
    public string Name;
    public uint Age;
    public char Gender;

    public bool SuisideRisk(warningssigns)
    {
        if warningsigns == True
            ConsoleWriteLine("This Person does have warningsigns and should seek help")
        else 
            ConsoleWriteLine("This person does not show any warningsigsn")        
    }
    public void StartConversation()
    {
        Console.WriteLine("Starting conversation");
        Console.WriteLine("1. Greetings friend, How are you doing today?");
        Console.WriteLine("2. Sup nerd hows it hangin?");
        Console.WriteLine("3. Nevermind, i got somewhere else to be!");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"I am doign very well thank you, What are you doing today?.");
                break;
            case "2":
                Console.WriteLine("Im Skibidi Rizz Fam, Whats the sitch?");
                break;
            case "3":
                Console.WriteLine("Allrighty then, have a good day then");
                break;
            default:
                Console.WriteLine("I don't understand that....");
                break;
        }
    }
    public void StopConversation()
    {
        if choice == 3
            return Place
    }

    public void UseMonocle(Monocle)
      {

      }  

    
}