using Where_did_Bob_Go_VA.NPC_NS;

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

       

        //+ Movement_in_room():
        //public void Movement_in_room()
        

        //+ Move_to_NPC(NPC):
        public void Move_to_NPC(NPC person)
        {
            person.StartConversation();
        }

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
        {
            Console.WriteLine(description);
        }
        //+ Display_NPC's():
        public void Display_NPCList()
        {
            for (int i = 0; i < NPCList.Lenght; i++)
            {
                if (NPCList[i] != null && NPCList[i].Visibility)
                {
                    Console.WriteLine(NPCList[i].Name);
                }
            }
        }
    }

}
