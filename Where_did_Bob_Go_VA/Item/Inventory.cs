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
                ItemMap.Add(item.Name, item);
                Change_TextBox_Main(item.Name +" has been added to the inventory.");
                Change_TextBox_Options("Press Enter...");

                Display_Inventory_Textbox(1);
                Update_GUI();
            }
            else
            {
                Console.WriteLine(item.Name + " already in inventroy.");
            }

            return;
        }


        // metode til use.int
        public void Use(string name)
        {
            if (name.Length != 0)
            {
                if (ItemMap.ContainsKey(name))
                {
                    string temp_text = "";
                    temp_text = "You have used " + name + "\n" + ItemMap[name].Use();
                    Change_TextBox_Main(temp_text); Change_TextBox_Options("Press Enter...");
                    if (ItemMap[name].Removeable)
                    {
                        Remove(name);
                    }
                }
                else
                {
                    Console.WriteLine(name + " not found in the inventory.");
                }

            }
            else
            {
                Console.WriteLine("Couldn't find a Item, without a name.");
            }

            Display_Inventory_Textbox(1);
            Update_GUI();
        }




        //metode til Remove.int 
        public void Remove(string name)
        {
            if ( ItemMap.Remove(name) )
            {
                Change_TextBox_Options("Press Enter...");
            }
            else
            {
                Console.WriteLine(name + " couldn't be removed from the inventory.");
            }

            Display_Inventory_Textbox(1);
            Update_GUI();
        }



        //Remove Item 
        public void Remove(Item item)
        {
            if (ItemMap.Remove(item.Name))
            {
                Change_TextBox_Options(item.Name + " removed from the inventory.");
            }
            else
            {
                Change_TextBox_Options(item.Name + " not found in the inventory.");
            }

            Display_Inventory_Textbox(1);
            Update_GUI();
        }



        //display inventory 
        public void Display()
        {

            string inventory_Description;

            inventory_Description = "Inventory: \n";

            foreach (KeyValuePair<string, Item> item in ItemMap)
            {
                inventory_Description = inventory_Description + "\n";
                inventory_Description = inventory_Description + item.Value.Name + ": \n";
                inventory_Description = inventory_Description + item.Value.Description + "\n";
            }

            Change_TextBox_Main(inventory_Description);
            Change_TextBox_Options("Press Enter...");

            Display_Inventory_Textbox(1);
            Update_GUI();
        }



        public void Display_Inventory_Textbox(int mode = 0)
        {

            string inventory_Description = "";

            foreach (KeyValuePair<string, Item> item in ItemMap)
            {
                inventory_Description = inventory_Description + item.Value.Name + " \n";
            }

            if (mode == 0)
            {
                Update_TextBox_Inventory(inventory_Description);
            }
            else if (mode == 1)
            {
                Change_TextBox_Inventory(inventory_Description);
            }
        }

    }
}