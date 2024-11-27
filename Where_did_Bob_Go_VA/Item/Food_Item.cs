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

namespace Where_did_Bob_Go_VA.Item_NS
{

    public class Food_Item : Item
    {
        public Food_Item(string name, string description) : base(name, description)
        {
            // .
        }

        public override string Use()
        {
            Game.player.RestoreHealth();
            return "You got +1 health";
        }
        public override string ToString()
        {
            return (base.ToString());
        }
    }
}
