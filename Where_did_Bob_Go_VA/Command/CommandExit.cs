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

namespace Where_did_Bob_Go_VA.Command_NS
{


    /* Command for exiting program
     */

    public class CommandExit : BaseCommand, ICommand
    {

        public CommandExit()
        {

            command_use_text = new string[1];
            command_use_text[0] = "Close";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            context.MakeDone();
        }
    }

}
