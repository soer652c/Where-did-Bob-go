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

namespace Where_did_Bob_Go_VA.Command_NS
{


    /* Baseclass for commands
     */

    public class BaseCommand
    {
        protected string description = "Undocumented";

        protected bool GuardEq(string[] parameters, int bound)
        {
            return parameters.Length != bound;
        }

        public String GetDescription()
        {
            return description;
        }
    }



}
