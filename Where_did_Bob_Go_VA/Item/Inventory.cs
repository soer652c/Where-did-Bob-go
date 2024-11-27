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
using System.Xml.Linq;


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
                Update_TextBox_Options(item.Name +" Has been added to the inventory");
            }
            else
            {
                Update_TextBox_Options(item.Name + " already in inventroy");
            }

            return;
        }

        // metode til use.int
        public void Use(string name)
        {
            if (name != null)
            {
                if (ItemMap.ContainsKey(name))
                {
                    string temp_text = "";
                    temp_text = "You have used " + name + "\n" + ItemMap[name].Use();
                    Update_TextBox_Main(temp_text);
                    if (ItemMap[name].Removeable)
                    {
                        Remove(name);
                    }
                }
                else
                {
                    Update_TextBox_Options(name + " not found on the list in Inventory");
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
                Update_TextBox_Options(name + " not found in the inventory.");
            }
        }
        //Remove Item 
        public void Remove(Item item)
        {
            if (ItemMap.Remove(item.Name))
            {
                Update_TextBox_Options(item.Name + " removed from the inventory.");
            }
            else
            {
                Update_TextBox_Options(item.Name + " not found in the inventory.");
            }
        }
        //display inventory 
        public void Display()
        {
            Update_TextBox_Options("Inventorylist");

            string[] cocoon = new string[ItemMap.Count];
            int interger = 0;

            foreach (KeyValuePair<string, Item> item in ItemMap)
            {
                cocoon[interger] = item.Value.Name + ": " + item.Value.Description ;
                interger++;
            }
            Update_TextBox_Options(cocoon);
        }
    }
}