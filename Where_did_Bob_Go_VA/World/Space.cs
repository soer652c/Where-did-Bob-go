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
using System.Xml.Linq;

namespace Where_did_Bob_Go_VA.World_NS
{


    /* Space class for modeling spaces (rooms, caves, ...)
     */

    public class Space : Node
    {
        public string name; 
        private string description;

        public Dictionary<string, NPC> NPC_Map = new Dictionary<string, NPC>();
        public Dictionary<string, Item> Item_Map = new Dictionary<string, Item>();



        public Space(String name, string description) : base(name)
        {
            this.description = description;
            this.name = name;
        }
        public Space(String name, string description, Dictionary<string, NPC> Init_NPCMap) : base(name)
        {
            this.description = description;
            this.NPC_Map = Init_NPCMap;
            this.name = name;
        }
        public Space(String name, string description, NPC Init_NPC, Item Init_Item) : base(name)
        {
            this.description = description;
            this.name = name;
            this.NPC_Map.Add(Init_NPC.NPC_Name, Init_NPC);
            this.Item_Map.Add(Init_Item.Name, Init_Item);
        }
        public Space(String name, string description, NPC Init_NPC) : base(name)
        {
            this.description = description;
            this.name = name;
            this.NPC_Map.Add(Init_NPC.NPC_Name, Init_NPC);
        }
        public Space(String name, string description, NPC Init_NPC, NPC Init_NPC2) : base(name)
        {
            this.description = description;
            this.name = name;
            this.NPC_Map.Add(Init_NPC.NPC_Name, Init_NPC);
            this.NPC_Map.Add(Init_NPC2.NPC_Name, Init_NPC2);
        }
        public Space(String name, string description, NPC Init_NPC, NPC Init_NPC2, Item Init_Item) : base(name)
        {
            this.description = description;
            this.name = name;
            this.NPC_Map.Add(Init_NPC.NPC_Name, Init_NPC);
            this.NPC_Map.Add(Init_NPC2.NPC_Name, Init_NPC2);
            this.Item_Map.Add(Init_Item.Name, Init_Item);
        }

        public Space(String name, string description, Dictionary<string, NPC> Init_NPCMap, Dictionary<string, Item> Init_ItemMap) : base(name)
        {
            this.description = description;
            this.NPC_Map = Init_NPCMap;
            this.Item_Map = Init_ItemMap;
            this.name=name;
        }

        public Space(String name, string description, Dictionary<string, NPC> Init_NPCMap, Item Init_Item) : base(name)
        {
            this.description = description;
            this.NPC_Map = Init_NPCMap;
            this.Item_Map.Add(Init_Item.Name,Init_Item);
            this.name = name;
        }
        public Space(String name, string description, Item Init_Item) : base(name)
        {
            this.description = description;
            this.Item_Map.Add(Init_Item.Name, Init_Item);
            this.name = name;
        }
        public void Welcome(string PreviousName)
        {
            // .
            HashSet<string> exits = edges.Keys.ToHashSet();

            // .
            string[] welcome_description = new string[7 + NPC_Map.Count + Item_Map.Count];

            welcome_description[0] = "You are now at " + name;
            welcome_description[1] = description;
            welcome_description[2] = "";
            welcome_description[3] = "You see the following NPCs: ";


            int NPC_Number = 4;
            foreach (KeyValuePair<string, NPC> npc in NPC_Map)
            {
                if (npc.Value.NPCvisibility)
                {
                    welcome_description[NPC_Number] = npc.Value.NPC_Name;
                    NPC_Number++;
                }
            }

            welcome_description[NPC_Number] = "";
            NPC_Number++;


            welcome_description[NPC_Number] = "You see the following items: ";

            int Item_Number = NPC_Number + 1;
            foreach (KeyValuePair<string, Item> item in Item_Map)
            {
                welcome_description[Item_Number] = item.Value.Name;
                Item_Number++;
            }

            string welcome_description_str = string.Join("\n", welcome_description);

            Change_TextBox_Main(welcome_description_str);



            // .   
            // .   
            string[] exits_string = new string[(exits.Count() + 1)];

            exits_string[0] = ("Current exits are:");

            // .   
            for (int i = 0; i < exits.Count(); i++)
            {
                exits_string[i + 1] = (" - " + exits.ElementAt(i));
            }

            // .  
            Change_TextBox_Options(exits_string);

            // .
            Change_TextBox_TopMiddle( PreviousName + " --> " + name );

            // . 
            Update_GUI();
        }

        public void Welcome()
        {
            // .
            HashSet<string> exits = edges.Keys.ToHashSet();

            // .
            string[] welcome_description = new string[7 + NPC_Map.Count + Item_Map.Count];

            welcome_description[0] = "You are now at " + name;
            welcome_description[1] = description;
            welcome_description[2] = "";
            welcome_description[3] = "You see the following NPCs: ";


            int NPC_Number = 4;
            foreach (KeyValuePair<string, NPC> npc in NPC_Map)
            {
                if (npc.Value.NPCvisibility)
                { 
                    welcome_description[NPC_Number] = npc.Value.NPC_Name;
                    NPC_Number++;
                }
            }

            welcome_description[NPC_Number] = "";
            NPC_Number++;


            welcome_description[NPC_Number] = "You see the following items: ";

            int Item_Number = NPC_Number + 1; 
            foreach (KeyValuePair<string, Item> item in Item_Map)
            {
                welcome_description[Item_Number] = item.Value.Name;
                Item_Number++;
            }

            string welcome_description_str = string.Join("\n", welcome_description);

            Change_TextBox_Main(welcome_description_str);



            // .   
            // .   
            string[] exits_string = new string[ (exits.Count() + 1) ];

            exits_string[0] = ("Current exits are:");

            // .   
            for (int i = 0; i < exits.Count(); i++) 
            {
                exits_string[i+1] = ( " - " + exits.ElementAt(i) );
            }

            // .  
            Change_TextBox_Options(exits_string);

            // . 
            Update_GUI();
        }


        public void Goodbye()
        {
        }


        public override Space FollowEdge(string direction)
        {
            return (Space)(base.FollowEdge(direction));
        }

        //+ Movement_in_room():
        //public void Movement_in_room()
        

        //+ Move_to_NPC(NPC):
        public void Move_to_NPC(Context context, NPC npc)
        {
            NPC_Map[npc.NPC_Name].StartConversation(context);
        }


        public void Move_to_NPC(Context context, string name)
        {
            NPC_Map[name].StartConversation(context); ;
        }

        //public void Execute(Context context, string command, string[] parameters)
        //{
        //    // Check if an NPC is available in the context
        //    if (context.GetCurrent == null)
        //    {
        //        Console.WriteLine("There is no one here to talk to.");
        //        return;
        //    }
        //    if (command.ToLower() == "talk")
        //    {
        //        // Begin or continue dialog with the current NPC
        //        context.CurrentNPC.StartDialog();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid command. Try using 'talk'.");
        //    }
        //}


        //Retrunstatmant skal indholde, hvad er i det specifikke rum, Items og NPC
        public override string ToString()
        {
            string temp = description;
           
            temp = (temp + " " + "There is a man in the corner, don't you see him , \n + ");


            //ser på NPCMap efter <string, NPC> og giver den navnet NPCinSpace. 
            // Derefter skriver den decription og de NPC's ud den fandt på stedet
            foreach (KeyValuePair<string, NPC> NPCinSpace in NPC_Map)
            {
                temp = temp + "  " + NPCinSpace.Key;
            }

            // Bryder linjenen og skriver teksten ud
            temp = (temp + "\n These are your current items at this location");
            //Ser i ItemMap efter <string, Item> og giver den IteminSpace navnet.
            //Derefter skriver den decription ud og de items der på loacation
            foreach (KeyValuePair<string, Item > Iteminspace in Item_Map)
            {
                temp = temp + "  " + Iteminspace.Key;
            }
           
            return (temp);
        }   


        public override bool Equals(object space_ToCompare)
        {
            if ( ((Space) space_ToCompare).ToString() == this.ToString())
            {
                return true;
            }

            return false;
        }


        //+ Display_Rooms() displayer description i textbox main
        public override void DisplayRoom()
        {
            Welcome();
        }


        //+ Display_NPC's() den kigger igennem NPCMap
        public void Display_NPCList()
        {
            // .  
            string[] npc_String_List = new string[NPC_Map.Count];

            // .  
            int npc_String_Count = 0;
            
            // .  
            foreach (KeyValuePair<string, NPC> npc in NPC_Map)
            {
                if (npc.Value.NPCvisibility)
                {
                    npc_String_List[npc_String_Count] = npc.Value.NPC_Name;
                    npc_String_Count++;
                }
            }

            Update_TextBox_Main(npc_String_List);
        }


        //Metoden, skal kunne finde en item, Ved at lede item.map igennem. 
        public Item Take_Item(string item)
        {
            if (Item_Map.ContainsKey(item))
            {
                Item temp_item = Item_Map[item];
                Item_Map.Remove(item);
                return temp_item;
            }
            else
            {
                return null;
            }
        }


        //Metoden, skal kunne finde en item, Ved at lede item.map igennem. 
        public bool CheckFor_Item(string item)
        {
            return Item_Map.ContainsKey(item);
        }


        //Metoden, skal kunne finde en item, Ved at lede item.map igennem. 
        public bool CheckFor_NPC(string npc_name)
        {
            return NPC_Map.ContainsKey(npc_name);
        }
    }

}
