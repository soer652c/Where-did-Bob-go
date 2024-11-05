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

namespace Where_did_Bob_Go_VA.World_NS
{


    /* World class for modeling the entire in-game world
     */

    public class World
    {
        Space entry;

        public World()
        {

            NPC Empty = new NPC("");
            NPC Karen = new NPC("Karen");
            NPC Bo = new NPC("Bo");
            NPC Tim = new NPC("Tim");
            NPC Jay = new NPC("Jay");

            NPC[] TempNPCList = { Karen, Bo, Tim, Jay };
            NPC[] EmptyTempNPCList = { Empty, Empty, Empty, Empty };


            Space home = new Space("Home", "Something something description", EmptyTempNPCList);
            Space outside = new Space("Outside", "Something something description", EmptyTempNPCList);
            Space subway = new Space("Subway", "Something something description", TempNPCList);
            Space hospital = new Space("Hospital", "Something something description", TempNPCList);
            Space psychiatry = new Space("Psychiatry", "Something something description", TempNPCList);
            Space school = new Space("School", "Something something description", TempNPCList);
            Space community = new Space("Community", "Something something description", TempNPCList);
            Space park = new Space("Park", "Something something description", TempNPCList);
            Space playground = new Space("Playground", "Something something description", TempNPCList);
            Space bar = new Space("Bar", "Something something description", TempNPCList);


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