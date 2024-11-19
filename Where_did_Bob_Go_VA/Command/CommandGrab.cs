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
	public class CommandGrab : BaseCommand, ICommand
	{
        Registry registry;

        public CommandGrab(Registry registry)
        {
            this.registry = registry;
            this.description = "Display a help message";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
			if (string.IsNullOrEmpty(parameters[0]))
			{
				Console.WriteLine("Grab what?");
				return;
			}

            // .  
            Space current_space = Game.context.GetCurrent();

			// .  
            Item item = current_space.Take_Item(parameters[0]);

			if (item == null)
			{
				Console.WriteLine($"There is no {parameters[0]} here.");
			}
			else
			{
                Game.inventory.Add(item);
			}
		}
	}
}
