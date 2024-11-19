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


namespace Where_did_Bob_Go_VA.Item_NS
{
    public class Inventory
    {
        public Dictionary<string, Item> ItemMap = new Dictionary<string, Item>();;

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
                Update_TextBox_Main(Item "{item.Name}" tilføjet til inventory);
            }
            else
            {
                Update_TextBox_main(Item already in inventroy);
            }
         
        }

        // Metode Use Item
        public void Use(Item item)
        {
            if (ItemMap.ContainsKey(item.Name))
            {
                Update_TextBox_Main("You used this item");
                item.Use();
            }
            else
            {
                Update_TextBox_Main("Item not found on the list in Inventory");
            }
        }
        // metode til use.int
        public void Use(int number)
        {
            if (number >= 0 && number < ItemMap.Count)
            {
                string key = GetKeyNumber(number);
                if (key != null)
                {
                    ItemMap[key].Use();
                    Update_TextBox_Main(Du har brugt dette item);
                }
            }
            else
            {
                Update_TextBox_Main ("Invalid, list is out of range");
            }
        }
        //metode til Remove.int 
        public void Remove(int number)
        {
            if (number >= 0 && number < ItemMap.Count)
            {
                string key = GetKeyByIndex(number);
                if (key != null)
                {
                    ItemMap.Remove(key);
                    Update_TextBox_Main("Item removed from the inventory.");
                }
            }
            else
            {
                Update_TextBox_Main("Invalid");
            }
        }
        //Remove Item 
        public void Remove(Item item)
        {
            if (ItemMap.Remove(item.Name))
            {
                Update_TextBox_Main("Item removed from the inventory.");
            }
            else
            {
                Update_TextBox_Main("Item not found in the inventory.");
            }
        }
        //display inventory 
        public void Display()
        {
            Update_TextBox_Main("Inventorylist");
            foreach (Item item in ItemMap)
            {
                string[] cocoon = { (item.Name), ("This is the name Item; " + item.Name), (" And this is the description of the item: " + item.Description) };
                Update_TextBox_Main(cocoon);
            }
        }
    }
}