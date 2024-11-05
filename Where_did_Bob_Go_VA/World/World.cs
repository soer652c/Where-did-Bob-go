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

            NPC Karen = new NPC();
            NPC Bo = new NPC();
            NPC Tim = new NPC();
            NPC Jay = new NPC();

            NPC[] TempNPCList = { Karen, Bo, Tim, Jay };


            Space entry = new Space("Entry", "Something something description", TempNPCList);
            Space outside = new Space("Outside", "Something something description", TempNPCList);
            Space subway = new Space("Subway", "Something something description", TempNPCList);
            Space hospital = new Space("Hospital", "Something something description", TempNPCList);
            Space psychiatry = new Space("Psychiatry", "Something something description", TempNPCList);
            Space school = new Space("School", "Something something description", TempNPCList);
            Space community = new Space("Community", "Something something description", TempNPCList);
            Space park = new Space("Park", "Something something description", TempNPCList);
            Space playground = new Space("Playground", "Something something description", TempNPCList);
            Space bar = new Space("Bar", "Something something description", TempNPCList);


            entry.AddEdge("door", outside);
            outside.AddEdge("south", subway);
            outside.AddEdge("west", school);
            outside.AddEdge("east", park);
            outside.AddEdge("south east", bar);
            park.AddEdge("north", playground);
            school.AddEdge("north", community);
            subway.AddEdge("north", outside);
            outside.AddEdge("south west", hospital);
            hospital.AddEdge("south", psychiatry);

            this.entry = entry;
        }

        public Space GetEntry()
        {
            return entry;
        }
    }

}