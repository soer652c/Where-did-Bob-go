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


    /* World class for modeling the entire in-game world
     */

    public class World
    {
        Space entry;

        public World()
        {
            Space entry = new Space("Entry");
            Space outside = new Space("Outside");
            Space subway = new Space("Subway");
            Space hospital = new Space("Hospital");
            Space psychiatry = new Space("Psychiatry");
            Space school = new Space("School");
            Space community = new Space("Community");
            Space park = new Space("Park");
            Space playground = new Space("Playground");
            Space bar = new Space("Bar");


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