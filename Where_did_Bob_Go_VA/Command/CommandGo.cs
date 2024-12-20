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


    /* Command for transitioning between spaces
     */

    public class CommandGo : BaseCommand, ICommand
    {
        public CommandGo()
        {
            description = "Moves to a new location.";

            command_use_text = new string[1];
            command_use_text[0] = "go [exits]";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            if (GuardEq(parameters, 1))
            {
                Console.WriteLine("I don't seem to know where that is"); //Må den godt være console.writeline?
                return;
            }
            context.Transition(parameters[0]);
        }
    }


}
