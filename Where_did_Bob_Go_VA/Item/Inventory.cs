using System;
using System.Diagnostics;

using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.GUI_NS;
using Where_did_Bob_Go_VA.Item_NS;
using Where_did_Bob_Go_VA.NPC_NS;
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;
using Where_did_Bob_Go_VA.Player_NS;
using Where_did_Bob_Go_VA.Proc_Gen_NS;
using Where_did_Bob_Go_VA.World_NS;
using Where_did_Bob_Go_VA.Game_NS;

using static Where_did_Bob_Go_VA.GUI_NS.GUI;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace Where_did_Bob_Go_VA.Item_NS
{
    public class Inventory
    {
        public Dictionary<string, Item> ItemMap = new Dictionary<string, Item>();

        //constructor
        public Inventory()
        {

        }

        //Metode Add.Item
        public void Add(Item item)
        {
            if (!ItemMap.ContainsKey(item.Name))
            {
                ItemMap[item.Name] = item;
                Update_TextBox_Main(item.Name +" Has been added to the inventory");
            }
            else
            {
                Update_TextBox_Main(item.Name + " already in inventroy");
            }

            return;
        }

        // Metode Use Item
        public void Use(Item item)
        {
            if (ItemMap.ContainsKey(item.Name))
            {
                ItemMap[item.Name].Use();
                Update_TextBox_Main("You have used this " + item.Name);
            }
            else
            {
                Update_TextBox_Main(item.Name + " not found on the list in Inventory");
            }
        }
        // metode til use.int
        public void Use(string name)
        {
            if (name != null)
            {
                if (ItemMap.ContainsKey(name))
                {
                    ItemMap[name].Use();
                    Update_TextBox_Main("You have used the item " + name);
                    Remove(name);
                }
                else
                {
                    Update_TextBox_Main(name + " not found on the list in Inventory");
                }

            }
            else
            {
                Update_TextBox_Main("item had no name");
            }
        }
        //metode til Remove.int 
        public void Remove(string name)
        {
            if ( ItemMap.Remove(name) )
            {

            }
            else
            {
                Update_TextBox_Main(name + " not found in the inventory.");
            }
        }
        //Remove Item 
        public void Remove(Item item)
        {
            if (ItemMap.Remove(item.Name))
            {
                Update_TextBox_Main(item.Name + " removed from the inventory.");
            }
            else
            {
                Update_TextBox_Main(item.Name + " not found in the inventory.");
            }
        }
        //display inventory 
        public void Display()
        {
            Update_TextBox_Main("Inventorylist");
            foreach (KeyValuePair<string, Item> item in ItemMap)
            {
                string[] cocoon = { (item.Value.Name), ("This is the name Item; " + item.Value.Name), (" And this is the description of the item: " + item.Value.Description) };
                Update_TextBox_Main(cocoon);
            }
        }
    }
}