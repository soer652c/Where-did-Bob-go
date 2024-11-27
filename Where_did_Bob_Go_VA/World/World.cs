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

using static Where_did_Bob_Go_VA.GUI_NS.GUI;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel;

namespace Where_did_Bob_Go_VA.World_NS
{


    /* World class for modeling the entire in-game world
     */

    public class World
    {
        Space entry;
        public Dictionary<string, Space> SpaceMap = new Dictionary<string, Space>();
        public World()
        {

            //NPC Empty = new NPC("");
            //NPC Karen = new NPC("Karen");
            //NPC Bo = new NPC("Bo");
            //NPC Tim = new NPC("Tim");
            //NPC Jay = new NPC("Jay"); 

            //NPC[] TempNPCList = { Karen, Bo, Tim, Jay };
            //NPC[] EmptyTempNPCList = { Empty, Empty, Empty, Empty };

            Dictionary<string, NPC> Temp_NPC_List = new Dictionary<string, NPC>();



            Temp_NPC_List.Add("Karen", new NPC("Karen", "", "")); 
            Temp_NPC_List.Add("Bo", new NPC("Bo", "", "")); 
            Temp_NPC_List.Add("Tim", new NPC("Tim", "", "")); 
            Temp_NPC_List.Add("Nina", new NPC("Nina", "", "")); 
           

            Item Banana = new Item("Banana", "a long one");


            Space home = new Space("home", "Its cozy and you feel comfortable", Temp_NPC_List, Banana);
            Space outside = new Space("outside", "The weather is nice and you feel a calming breeze", Temp_NPC_List, Banana);
            Space subway = new Space("subway", "there are a lot of people rushing by", Temp_NPC_List);
            Space hospital = new Space("hospital", "Doctors, nurses and patients roam the halls", Temp_NPC_List);
            Space psychiatry = new Space("psychiatry", "you have a unsetteling feeling that you don't belong here", Temp_NPC_List);
            Space school = new Space("school", "Children are playing around on the playground", Temp_NPC_List);
            Space community = new Space("community", "you feel at ease here", Temp_NPC_List);
            Space park = new Space("park", "The weather is plesant and you feel the joyfull atmosphere", Temp_NPC_List);
            Space playground = new Space("playground", "Children are playing around and some parents are camped on the benches nearby", Temp_NPC_List);
            Space bar = new Space("bar", "the music is playing in the background and people are drinking diverse alcoholic beverages", Temp_NPC_List);


            home.AddEdge("outside", outside);
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
            for (int k=0; SpaceMap.Count > 0; k++)
            {
                string v = Convert.ToString(k);
                //Kig i Space, og find NPSList;
                Space currentSpace = SpaceMap[v];
                // FOR LOOP
                foreach (KeyValuePair<string, NPC> npcEntry in currentSpace.NPCMap)
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