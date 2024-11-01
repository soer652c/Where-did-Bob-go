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


    /* Command for transitioning between spaces
     */

    public class CommandGo : BaseCommand, ICommand
    {
        public CommandGo()
        {
            description = "Follow an exit";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            if (GuardEq(parameters, 1))
            {
                Console.WriteLine("I don't seem to know where that is 🤔");
                return;
            }
            context.Transition(parameters[0]);
        }
    }


}
