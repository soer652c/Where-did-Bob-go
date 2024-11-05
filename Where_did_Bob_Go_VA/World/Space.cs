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

        public NPC[] NPCList;

        public Space(String name, string description, NPC[] NPCList) : base(name)
        {
            this.description = description;
            this.NPCList = NPCList;
        }


        public void Welcome()
        {
            // .
            HashSet<string> exits = edges.Keys.ToHashSet();

            // .
            string[] welcome_description = new string[3];

            welcome_description[0] = "You are now at " + name;
            welcome_description[1] = description;

            Update_TextBox_Main(welcome_description);


            // .   
            string[] exits_string = new string[ (exits.Count() + 1) ];

            exits_string[0] = ("Current exits are:");

            // .   
            for (int i = 0; i < exits.Count(); i++) 
            {
                exits_string[i+1] = ( " - " + exits.ElementAt(i) );
            }

            // .  
            Update_TextBox_Options(exits_string);
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
        public void Move_to_NPC(NPC person)
        {
            person.StartConversation();
        }

        public string ToString()
        {
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
            for (int i = 0; i < NPCList.Length; i++)
            {
                if (NPCList[i] != null && NPCList[i].NPCvisibility)
                {
                    Console.WriteLine(NPCList[i].NPCname);
                }
            }
        }
    }

}
