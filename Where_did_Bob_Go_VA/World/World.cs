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

        int NPCVisualbilitiCounter;

        public World(NPC_DialogID[] npc_DialogID_Arr)
        {

            Dictionary<string, NPC> Init_NPCMap = new Dictionary<string, NPC>();


            NPC Alex = new NPC(npc_DialogID_Arr[0], npc_DialogID_Arr[0].NPC_Name);
            NPC Mia = new NPC(npc_DialogID_Arr[1], npc_DialogID_Arr[1].NPC_Name);
            NPC Liam = new NPC(npc_DialogID_Arr[2], npc_DialogID_Arr[2].NPC_Name);
            NPC Clara = new NPC(npc_DialogID_Arr[3], npc_DialogID_Arr[3].NPC_Name);
            NPC Jack = new NPC(npc_DialogID_Arr[4], npc_DialogID_Arr[4].NPC_Name);
            NPC Emma = new NPC(npc_DialogID_Arr[5], npc_DialogID_Arr[5].NPC_Name);
            NPC Steen = new NPC(npc_DialogID_Arr[6], npc_DialogID_Arr[6].NPC_Name);
            NPC Thomas = new NPC(npc_DialogID_Arr[7], npc_DialogID_Arr[7].NPC_Name);
            NPC Sarah = new NPC(npc_DialogID_Arr[8], npc_DialogID_Arr[8].NPC_Name);
            NPC Ben = new NPC(npc_DialogID_Arr[9], npc_DialogID_Arr[9].NPC_Name);
            NPC Lily = new NPC(npc_DialogID_Arr[10], npc_DialogID_Arr[10].NPC_Name);
            NPC James = new NPC(npc_DialogID_Arr[11], npc_DialogID_Arr[11].NPC_Name);


            // The NPC's located around the world of Bob
            Init_NPCMap.Add(Liam.NPC_Name, Liam);
            Init_NPCMap.Add(Clara.NPC_Name,Clara);
            Init_NPCMap.Add(Jack.NPC_Name, Jack);
            Init_NPCMap.Add(Emma.NPC_Name, Emma);
            Init_NPCMap.Add(Steen.NPC_Name, Steen);
            Init_NPCMap.Add(Thomas.NPC_Name, Thomas);
            Init_NPCMap.Add(Sarah.NPC_Name, Sarah);
            Init_NPCMap.Add(Ben.NPC_Name, Ben);
            Init_NPCMap.Add(Lily.NPC_Name, Lily);
            Init_NPCMap.Add(James.NPC_Name, James);
            Init_NPCMap.Add(Mia.NPC_Name, Mia);
            Init_NPCMap.Add(Alex.NPC_Name, Alex);
            //-----------------------------------------------------

            //NPC_Options(Sophie, Liam, Clara, Jack, Emma, Steen, Thomas, Sarah, Ben, Lily, James, Mia, Alex)


            // The Food items located around the world of Bob
            Item Banana = new Food_Item("Banana", "A Tasty Banana, can be eaten to gain 1 health");
            Item Apple = new Food_Item("Apple", "A Tasty Apple, Can be eaten to gain 1 health");
            Item Sandwich = new Food_Item("Sandwich", "A Tasty Sandwich, Can be eaten to gain 1 health");
            Item Mirror = new MirrorOfReflection();
            // ----------------------------------------------

            Space home = new Space("home", "You stand in your cozy apartment. \nSunlight shines through the windows, lighting up the rooms. \nThe warm light landing on the furniture’s and the potted plants in the windowsills. \nThe sound of the busy streets outside hums like white noise in the background. \n\nYou wonder if you should go outside to explorer.");
            Space outside = new Space("outside", "The weather is nice and you feel a calming breeze. \nThe sun is hitting the trees, giving a nice warm feeling in the mind.");
            Space subway = new Space("subway", "You descend into the dim subway, the air heavy with echoes and grime.", Jack, Mia, Banana);
            Space hospital = new Space("hospital", "Doctors, nurses and patients roam the halls", Emma);
            Space psychiatry = new Space("psychiatry", "you have a unsetteling feeling that you don't belong here", Steen, Thomas, Mirror);
            Space school = new Space("school", "Children are playing around on the playground, \n since the weather is nice. \n You hear screams and laughter around you. \nSeems as though you are in a fun place...maybe", Clara, Liam, Apple);
            Space community = new Space("community", "you feel at ease here. \n A lot of people came here from school it seems. \n It is dark and gloomy outside, \nbut it is bright and cheerful inside.", Sarah);
            Space park = new Space("park", "The park is covered in lush green grass and majestic trees. \nYou spot people relaxing at the fountain and in the shade. \nYou can hear  the sound of children having fun. \nYou can see the playground at the other end of the park.", Ben);
            Space playground = new Space("playground", "Children are playing\naround and some parents are camped on the benches nearby", Lily, James);
            Space bar = new Space("bar", "The music is playing in the background and people are drinking \n you make the way to floor \n you zone in an dance the nigth away", Alex, Sandwich);


            home.AddEdge(outside.name, outside);
            outside.AddEdge(home.name, home);
            outside.AddEdge(subway.name, subway);
            outside.AddEdge(school.name, school);
            outside.AddEdge(park.name, park);
            outside.AddEdge(bar.name, bar);
            outside.AddEdge(hospital.name, hospital);
            bar.AddEdge(outside.name, outside);
            park.AddEdge(playground.name, playground);
            playground.AddEdge(park.name, park);
            park.AddEdge(outside.name, outside);
            school.AddEdge(community.name, community);
            community.AddEdge(school.name, school);
            school.AddEdge(outside.name, outside);
            subway.AddEdge(outside.name, outside);
            hospital.AddEdge(psychiatry.name, psychiatry);
            psychiatry.AddEdge(hospital.name, hospital);
            hospital.AddEdge(outside.name, outside);

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
            NPCVisualbilitiCounter = 0;
            
            foreach (KeyValuePair<string, Space> currentSpace in SpaceMap)
            {
                foreach (KeyValuePair<string, NPC> currentNPC in (currentSpace).Value.NPC_Map)
                {
                    NPC npc = currentNPC.Value;

                    //NPC's synlighed øg tælleren
                    //Går igennem NPC_Map og tjekker om hver NPC er synlig 
                    //IF NPC synlig tilføj til NPCVisualbilitiCounter;
                    if (npc.NPCvisibility)
                    {
                        NPCVisualbilitiCounter++;
                    }
                }
            }

            return NPCVisualbilitiCounter;
        }
        public int NPCTopRight()
        {
            NPCLeft();
            string? NPCString = NPCVisualbilitiCounter.ToString();
            Change_TextBox_TopRight("NPC left: " + NPCString);
            return NPCVisualbilitiCounter;
        }
    }

}