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


    /* Help command
     */

    public class CommandHelp : BaseCommand, ICommand
    {
        Registry registry;

        public CommandHelp(ref Registry registry)
        {
            this.registry = registry;
            this.description = "Display a help message";

            command_use_text = new string[1];
            command_use_text[0] = "help";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            string[] commandNames = registry.GetCommandNames();
            Array.Sort(commandNames);

            // find max length of command name
            int max = 0;
            foreach (String commandName in commandNames)
            {
                int length = commandName.Length;
                if (length > max) max = length;
            }

            // present list of commands
            Console.WriteLine("Commands:");
            foreach (String commandName in commandNames)
            // Denne overskriver nuværende tekst i comand boxen
            {
                string description = registry.GetCommand(commandName).GetDescription();
                Console.WriteLine(" - {0,-" + max + "} " + description, commandName);
                // Skal dette ikke skrives i comand boxen
            }

            Console.ReadLine();

            (context.GetCurrent()).DisplayRoom();


        }
    }


}
