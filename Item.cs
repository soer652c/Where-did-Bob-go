public class Item
{
    //atribut
    public string nameOfItem;
    public string description;

    //constructor 
    public Item(string init_nameOfItem, string init_description)
    {
        this.nameOfItem = init_nameOfItem;
        this.description = init_description;
    }

    //metode
    public virtual void Use()
    {
        return ();
    }
}