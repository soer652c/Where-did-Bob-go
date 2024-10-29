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
    public void StartConversation
    
}