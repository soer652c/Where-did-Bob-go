using Where_did_Bob_Go_VA.NPC_NS;

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

        //+ Movement_in_room():
        public void NPCInRoom()
        {
            
        }



        //+ Move_to_NPC(NPC): We just need a plain talk to npc, we don't need to move anywhere
        public override string ToString()
        {
            return SuicideRisk;
        }
        public override bool Equals(object NPCList_ToCompare)
        {
            if (((NPC)NPCList_ToCompare).NPCList() == NPCList)
            {
                return true;
                Console.WriteLine(SuicideRisk);
            }

            return false;
        }
        //+ Display_Rooms(): vi skal lave rum færdig
        public void Display_Room()

        //+ Display_NPC's():
    }

}
