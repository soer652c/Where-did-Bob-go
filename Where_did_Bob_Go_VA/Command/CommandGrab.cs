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
            this.description = "Use grab to pick up items/food items in certain rooms";
        }

		// If you try to pick up an item thats not there, or if the item was taken before, the console will write "Grab what?"
        public void Execute(Context context, string command, string[] parameters)
        {
			if ( (parameters.Length == 0) || (String.IsNullOrEmpty(parameters[0])) )
			{
                Update_TextBox_Main ("Grab what?");
				return;
			}

            // Takes the space and grabs it. Defining what space/room ur in at the momement. 
            Space current_space = Game.context.GetCurrent();

			if (current_space.Take_Item(parameters[0]) == null)
			{

				Console.WriteLine("There is no item here, try another command");
			}
			
			// If there is an item it will add it to the inventory if not console writeline will say "There is no...". 
			// If theres no item and you write take "item" it will return null instead of crashing the game.
            Item item = current_space.Take_Item(parameters[0]);

			if (item == null)
			{
                Update_TextBox_Main ($"There is no {parameters[0]} here.");
			}
			else
			{
                Game.inventory.Add(item);
            }

            //Console.ReadLine();

            (Game.context.GetCurrent()).DisplayRoom();
        }
	}
}
