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

namespace Where_did_Bob_Go_VA.World_NS
{


    /* Space class for modeling spaces (rooms, caves, ...)
     */

    public class Space : Node
    {
        private string description;


        //List<NPC> NPCList = new List<NPC>();

        
        public Dictionary<string, NPC> NPCMap = new Dictionary<string, NPC>();
        public Dictionary<string, Item> ItemMap = new Dictionary<string, Item>();
        public Space(String name, string description, Dictionary<string, NPC> NPCList) : base(name)
        {
            this.description = description;
            this.NPCMap = NPCList;
        }


        public void Welcome()
        {
            // .
            HashSet<string> exits = edges.Keys.ToHashSet();

            // .
            string[] welcome_description = new string[7];

            welcome_description[0] = "You are now at " + name;
            welcome_description[1] = description;

            int NPC_Number = 2; 
            foreach (KeyValuePair<string, NPC> item in NPCMap)
            {
                welcome_description[NPC_Number] = item.Value.NPCname;
                NPC_Number++;
            }

            // .
            Change_TextBox_Main(welcome_description);


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
        public void Move_to_NPC(NPC npc)
        {
            NPCMap[npc.NPCname].StartConversation();
        }
        public void Move_to_NPC(string name)
        {
            NPCMap[name].StartConversation();
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


        public override string ToString()
        {
            // bodyen er tom

            // Return String.
            ////// REMBEMEBER TO CHANGE/UPDATE !!!! //////
            return "";
        }

        public override bool Equals(object space_ToCompare)
        {
            if ( ((Space) space_ToCompare).ToString() == this.ToString())
            {
                return true;
            }

            return false;
        }
        //+ Display_Rooms(): vi skal lave rum færdig
        public void Display_Room()
        {
            Update_TextBox_Main(description);
        }
        //+ Display_NPC's():
        public void Display_NPCList()
        {
            // .  
            string[] npc_String_List = new string[NPCMap.Count];

            // .  
            int npc_String_Count = 0;
            
            // .  
            foreach (KeyValuePair<string, NPC> npc in NPCMap)
            {
                if (npc.Value.NPCvisibility)
                {
                    npc_String_List[npc_String_Count] = npc.Value.NPCname;
                    npc_String_Count++;
                }
            }

            Update_TextBox_Main(npc_String_List);
        }
        //Metoden, skal kunne finde en item, Ved at lede item.map igennem. 
        public Item Take_Item(string item)
        { 
                if (ItemMap.ContainsKey(item))
                {
                return ItemMap[item];
                }
                else
                {
                return null; 
            }
        }
          
     
    }

}
