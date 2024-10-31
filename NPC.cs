namespace DefaultNamespace;

public class NPC
{
    public string Place;
    public Dialog_Tree;
    public bool Visibility;
    public bool Warningsigns;
    public string Name;
    public uint Age;
    public char Gender;

    public bool SuicideRisk(bool warningSigns)
    {
        // Reads the imput from console
        Console.ReadLine();
        if (warningSigns)
        {
            Console.WriteLine("This person does have warning signs and should seek help.");
            return true; 
            // Return true if there are warning signs
        }
        else 
        {
            Console.WriteLine("This person does not show any warning signs.");
            return false; 
            // Return false if there are no warning signs
        }
    public void StartConversation()
    {
        // Short term code, to test if our conversation works in the first place, Gonna be revised later on
        Console.WriteLine("Starting conversation");
        Console.WriteLine("1. Greetings friend, How are you doing today?");
        Console.WriteLine("2. Sup nerd hows it hangin?");
        Console.WriteLine("3. Nevermind, i got somewhere else to be!");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine("I am doign very well thank you, What are you doing today?.");
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

    public void Identifiers()
    {
        string
    }
    public bool GuessImput(Warningsigns)
    {
        Guess = Console.ReadLine();
    }

    public bool GuessCheck(Guess)
    {
        If Guess = True
            Console.WriteLine("You are correct, now have a cookie!")
    }
}