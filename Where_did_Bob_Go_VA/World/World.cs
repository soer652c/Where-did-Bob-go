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
            Space corridor = new Space("Corridor");
            Space cave = new Space("Cave");
            Space pit = new Space("Darkest Pit");
            Space outside = new Space("Outside");

            entry.AddEdge("door", corridor);
            corridor.AddEdge("door", cave);
            cave.AddEdge("north", pit);
            cave.AddEdge("south", outside);
            pit.AddEdge("door", cave);
            outside.AddEdge("door", cave);

            this.entry = entry;
        }

        public Space GetEntry()
        {
            return entry;
        }
    }

}