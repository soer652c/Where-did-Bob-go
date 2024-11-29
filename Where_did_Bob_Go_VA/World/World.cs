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


    /* World class for modeling the entire in-game world
     */

    public class World
    {
        Space entry;
        public Dictionary<string, Space> SpaceMap = new Dictionary<string, Space>();

        public World(NPC_DialogID[] npc_DialogID_Arr)
        {

            Dictionary<string, NPC> Init_NPCMap = new Dictionary<string, NPC>();


            NPC Alex = new NPC(npc_DialogID_Arr[0], "Alex");
            NPC Sophie = new NPC(npc_DialogID_Arr[1], "Sophie");
            NPC Liam = new NPC(npc_DialogID_Arr[2], "Liam");
            NPC Clara = new NPC(npc_DialogID_Arr[3], "Clara");
            NPC Jack = new NPC(npc_DialogID_Arr[4], "Jack");
            NPC Emma = new NPC(npc_DialogID_Arr[5], "Emma");
            NPC Steen = new NPC(npc_DialogID_Arr[6], "Steen");
            NPC Thomas = new NPC(npc_DialogID_Arr[7], "Thomas");
            NPC Sarah = new NPC(npc_DialogID_Arr[8], "Sarah");
            NPC Ben = new NPC(npc_DialogID_Arr[9], "Ben");
            NPC Lily = new NPC(npc_DialogID_Arr[10], "Lily");
            NPC James = new NPC(npc_DialogID_Arr[11], "James");
            NPC Mia = new NPC(npc_DialogID_Arr[12], "Mia");


            // The NPC's located around the world of Bob
            Init_NPCMap.Add("Liam", Liam);
            Init_NPCMap.Add("Clara",Clara);
            Init_NPCMap.Add("Jack", Jack);
            Init_NPCMap.Add("Emma", Emma);
            Init_NPCMap.Add("Steen", Steen);
            Init_NPCMap.Add("Thomas", Thomas);
            Init_NPCMap.Add("Sarah", Sarah);
            Init_NPCMap.Add("Ben", Ben);
            Init_NPCMap.Add("Lily", Lily);
            Init_NPCMap.Add("James", James);
            Init_NPCMap.Add("Mia", Mia);
            Init_NPCMap.Add("Alex", Alex);
            //-----------------------------------------------------

            //NPC_Options(Sophie, Liam, Clara, Jack, Emma, Steen, Thomas, Sarah, Ben, Lily, James, Mia, Alex)


            // The Food items located around the world of Bob
            Item Banana = new Food_Item("Banana", "A Tasty Banana, can be eaten to gain 1 health");
            Item Apple = new Food_Item("Apple", "A Tasty Apple, Can be eaten to gain 1 health");
            Item Sandwich = new Food_Item("Sandwich", "A Tasty Sandwich, Can be eaten to gain 1 health");
            Item Mirror = new MirrorOfReflection();
            // ----------------------------------------------

            Space home = new Space("home", "Its cozy and you feel comfortable");
            Space outside = new Space("outside", "The weather is nice and you feel a calming breeze");
            Space subway = new Space("subway", "there are a lot of people rushing by", Jack, Mia, Banana);
            Space hospital = new Space("hospital", "Doctors, nurses and patients roam the halls", Emma);
            Space psychiatry = new Space("psychiatry", "you have a unsetteling feeling that you don't belong here", Steen, Thomas, Mirror);
            Space school = new Space("school", "Children are playing around on the playground", Clara, Liam, Apple);
            Space community = new Space("community", "you feel at ease here", Sarah);
            Space park = new Space("park", "The weather is plesant and you feel the joyfull atmosphere", Ben);
            Space playground = new Space("playground", "Children are playing\naround and some parents are camped on the benches nearby", Lily, James);
            Space bar = new Space("bar", "The music is playing in the background and people are drinking", Alex, Sandwich);


            home.AddEdge("outside", outside);
            outside.AddEdge("home", home);
            outside.AddEdge("subway", subway);
            outside.AddEdge("school", school);
            outside.AddEdge("park", park);
            outside.AddEdge("bar", bar);
            outside.AddEdge("hospital", hospital);
            bar.AddEdge("outside", outside);
            park.AddEdge("playground", playground);
            playground.AddEdge("park", park);
            park.AddEdge("outside", outside);
            school.AddEdge("community", community);
            community.AddEdge("school", school);
            school.AddEdge("outside", outside);
            subway.AddEdge("outside", outside);
            hospital.AddEdge("psychiatry", psychiatry);
            psychiatry.AddEdge("hospital", hospital);
            hospital.AddEdge("outside", outside);

            this.entry = home;
            SpaceMap.Add(home.name, home);
            SpaceMap.Add(outside.name, outside);
            SpaceMap.Add(subway.name, subway);
            SpaceMap.Add(hospital.name, hospital);
            SpaceMap.Add(psychiatry.name, psychiatry);
            SpaceMap.Add(school.name, school);
            SpaceMap.Add(community.name, community);
            SpaceMap.Add(park.name, park);
            SpaceMap.Add(playground.name, playground);
            SpaceMap.Add(bar.name, bar);
        }

        public Space GetEntry()
        {
            return entry;
        }


        public int NPCLeft()
        {
            int NPCVisualbilitiCounter = 0;
            for (int k = 0; SpaceMap.Count > 0; k++)
            {
                string v = Convert.ToString(k);
                //Kig i Space, og find NPSList;
                Space currentSpace = SpaceMap[v];
                // FOR LOOP
                foreach (KeyValuePair<string, NPC> npcEntry in currentSpace.NPC_Map)
                {
                    NPC nPC = npcEntry.Value;

                    //NPC's synlighed øg tælleren
                    //Går igennem NPC_Map og tjekker om hver NPC er synlig 
                    //IF NPC synlig tilføj til NPCVisualbilitiCounter;
                    if (NPCVisualbilitiCounter > 0)
                    {
                        NPCVisualbilitiCounter++;
                    }
                }

            }
            return NPCVisualbilitiCounter;
        }
    }

}