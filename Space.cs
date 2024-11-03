using System;
using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.GUI_NS;
using Where_did_Bob_Go_VA.Item_NS;
using Where_did_Bob_Go_VA.NPC_NS;
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;
using Where_did_Bob_Go_VA.Player_NS;
using Where_did_Bob_Go_VA.Proc_Gen_NS;
using Where_did_Bob_Go_VA.World_NS;
using Where_did_Bob_Go_VA.Game_NS;

namespace Where_did_Bob_Go_VA.World_NS
{


    /* Space class for modeling spaces (rooms, caves, ...)
     */

    public class Space : Node
    {
        public Space(String name) : base(name)
        {
        }

        public void Welcome()
        {
            Console.WriteLine("You are now at " + World);
            HashSet<string> exits = edges.Keys.ToHashSet();
            Console.WriteLine("Current exits are:");
            foreach (String exit in exits)
            {
                Console.WriteLine(" - " + exit);
            }
        }

        public void Goodbye()
        {
        }

        public override Space FollowEdge(string direction)
        {
            return (Space)(base.FollowEdge(direction));
        }

        List<NPC> NPCList = new List<NPC>();

        public bool SuisideRisk { get; private set; }

        //+ Movement_in_room():
        public void Movement_in_room()
        {
            
        }
        //+ Move_to_NPC(NPC):
        public override string ToString()
        {
            return SuisideRisk;
        }

        public override bool Equals(object NPCList_ToCompare)
        {
            if (((NPC)NPCList_ToCompare).NPCList() == NPCList)
            {
                return true;
                Console.WriteLine(SuisideRisk);
            }

            return false;
        }

        //+ Display_NPC's():
    }

}
