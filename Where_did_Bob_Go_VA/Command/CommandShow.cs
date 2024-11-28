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


        public CommandUse()
        {
            this.description = "  ....   ";
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

            ProcessCommand(thing_to_Show);

            // . Grapping the current location from the context data
            current_location = Game.context.GetCurrent();

            Console.ReadLine();

            current_location.Welcome();

            return;
        }
        public void ProcessCommand(string command)
        {
            switch (command.ToLower()) // To ensure that the text is always lowercase 
            {
                case "Show location":
                    Update_TextBox_Main(currentSpace.Description);
                    break;
                case "Show inventory":
                    player.Inventory.Display(); // Calls the Display method
                    break;
                /*case "use":
                    Update_TextBox_Main("What item would you like to use?");
                    string itemName = Console.ReadLine();
                    player.Inventory.Use(itemName); // Uses the item from inventory
                    break;*/
                case "Show items"
                    Update_TextBox_Main(currentSpace.Description)
                    break;
                default:
                    Update_TextBox_Main("I don't understand that command.");
                    break;
            }
        }
            public void ShowItemsInCurrentRoom()
            {
            Update_TextBox_Main("Items in this space:");

            if (Player.CurrentSpace.Items.Count == 0)
            {
                Update_TextBox_Main("There are no items here.");
                return;
            }

            foreach (string item in Player.CurrentSpace.Items)
            {
                Update_TextBox_Main(item.Name: item.Description);
            }
            }  
        

    }
}