using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
using static Where_did_Bob_Go_VA.Game;

namespace Where_did_Bob_Go_VA.Command_NS
{
    public class CommandShow : BaseCommand, ICommand
    {

        Space current_location;


        public CommandShow()
        {
            this.description = "Displays inventory";
        }

        // Metode til at udføre "Use"-kommandoen
        public void Execute(Context context, string command, string[] args)
        {
            // Tjek om argumentet er korrekt
            if (GuardEq(args, 1))
            {
                Console.WriteLine("Invalid input. Please specify what you want to see.");
                return;
            }

            // Hent item-navnet fra argumenterne
            string thing_to_Show = args[0];

            // . Grapping the current location from the context data
            current_location = context.GetCurrent();

            ProcessCommand(thing_to_Show, current_location);

            current_location = context.GetCurrent();

            current_location.Welcome();

            return;
        }



        public void ProcessCommand(string thing_to_Show, Space current_location)
        {
            switch (thing_to_Show.ToLower()) // To ensure that the text is always lowercase 
            {
                case "location":
                    // . 
                    break;
                case "inventory":
                    Game.inventory.Display(); // Calls the Display method
                    Console.ReadLine();
                    break;
                    /*case "use":
                    Update_TextBox_Main("What item would you like to use?");
                    string itemName = Console.ReadLine();
                    player.Inventory.Use(itemName); // Uses the item from inventory
                    break;*/
                default:
                    Console.WriteLine("I don't understand that command.");
                    break;
            }

            return;
        }
    }
}