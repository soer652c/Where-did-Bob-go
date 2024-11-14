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

public class CommandTalk : BaseCommand, ICommand
{
    public void Execute(Context context, string command, string[] parameters)
    {
        // Check if an NPC is available in the context
        if (context.CurrentNPC == null)
        {
            Console.WriteLine("There is no one here to talk to.");
            return;
        }
        if (command.ToLower() == "talk")
        {
            // Begin or continue dialog with the current NPC
            context.CurrentNPC.StartDialog();
        }
        else
        {
            Console.WriteLine("Invalid command. Try using 'talk'.");
        }
    }
}
