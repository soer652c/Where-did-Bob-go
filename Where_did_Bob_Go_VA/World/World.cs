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

namespace Where_did_Bob_Go_VA.World_NS
{


    /* World class for modeling the entire in-game world
     */

    public class World
    {
        Space entry;

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



            Temp_NPC_List.Add("Karen", new NPC("Karen")); 
            Temp_NPC_List.Add("Bo", new NPC("Bo")); 
            Temp_NPC_List.Add("Tim", new NPC("Tim")); 
            Temp_NPC_List.Add("Nina", new NPC("Nina")); 
           

            Item Banana = new Item("Banana", "a long one");




            Space home = new Space("Home", "Something something description", Temp_NPC_List, Banana);
            Space outside = new Space("Outside", "Something something description", Temp_NPC_List, Banana);
            Space subway = new Space("Subway", "Something something description", Temp_NPC_List);
            Space hospital = new Space("Hospital", "Something something description", Temp_NPC_List);
            Space psychiatry = new Space("Psychiatry", "Something something description", Temp_NPC_List);
            Space school = new Space("School", "Something something description", Temp_NPC_List);
            Space community = new Space("Community", "Something something description", Temp_NPC_List);
            Space park = new Space("Park", "Something something description", Temp_NPC_List);
            Space playground = new Space("Playground", "Something something description", Temp_NPC_List);
            Space bar = new Space("Bar", "Something something description", Temp_NPC_List);


            home.AddEdge("Outside", outside);
            outside.AddEdge("Subway", subway);
            outside.AddEdge("School", school);
            outside.AddEdge("Park", park);
            outside.AddEdge("Bar", bar);
            outside.AddEdge("Hospital", hospital);
            bar.AddEdge("Outside", outside);
            park.AddEdge("Playground", playground);
            playground.AddEdge("Park", park);
            park.AddEdge("Outside", outside);
            school.AddEdge("Community", community);
            community.AddEdge("School", school);
            school.AddEdge("Outside", outside);
            subway.AddEdge("Outside", outside);
            hospital.AddEdge("Psychiatry", psychiatry);
            psychiatry.AddEdge("Hospital", hospital);
            hospital.AddEdge("Outside", outside);

            this.entry = home;
        }

        public Space GetEntry()
        {
            return entry;
        }
    }

}