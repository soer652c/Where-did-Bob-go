public class Food_Item : Item
{
    public override string Use()
    {
        RestoreHealth();

        return "You got +1 health";
    }
    
}
