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
        public CommandGrab()
        {
            this.description = "Use grab to pick up items at your current location.";

            command_use_text = new string[1];
            command_use_text[0] = "grab [item]";
        }

		// If you try to pick up an item thats not there, or if the item was taken before, the console will write "Grab what?"
        public void Execute(Context context, string command, string[] parameters)
        {
			if ( (parameters.Length == 0) || (String.IsNullOrEmpty(parameters[0])) )
			{
				Console.WriteLine("Grab what?");
				return;
			}

            // Takes the space and grabs it. Defining what space/room ur in at the momement. 
            Space current_space = context.GetCurrent();

            if (current_space.CheckFor_Item(parameters[0]))
            {

                // If there is an item it will add it to the inventory if not console writeline will say "There is no...". 
                // If theres no item and you write take "item" it will return null instead of crashing the game.
                Item item = current_space.Take_Item(parameters[0]);

                if (item.Name != parameters[0])
                {
                    Console.WriteLine($"Couldn't grab the {parameters[0]} here.");
                }
                else
                {
                    if (Game.inventory.Add(item))
                    {
                        // . Grapping the current location from the context data
                        current_space = context.GetCurrent();
                        current_space.DisplayRoom();
                        return;
                    }
                }
            }
            else
            {
                Console.WriteLine($"Couldn't grab the {parameters[0]} at this location.");
            }

        }
	}
}
