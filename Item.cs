public class Item
{
    // Attributes 
    public string Name { get; }
    public string Description { get; }

    // Constructor 
    public Item(string name, string description)
    {
        this.Name = name;
        this.Description = description;
    }

    // Method
    public virtual string Use()
    {
        return $"You found a {Name}.";
    }
}