﻿using System;
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
    public class CommandUse : BaseCommand, ICommand
    {
        Registry registry;

        Space current_location;

        //Konstruktor der tager ser i regersty 
        public CommandUse()
        {
            this.description = "Allows you to use an item in your inventory.";

            command_use_text = new string[1];
            command_use_text[0] = "use [item]";
        }


        // Metode til at udføre "Use"-kommandoen
        public void Execute(Context context, string command, string[] args)
        {
            // Tjek om argumentet er korrekt
            if (GuardEq(args, 1))
            {
                Console.WriteLine("Invalid. Please specify an item to use. Item not found");
                return;
            }

            // Hent item-navnet fra argumenterne
            string itemName = args[0];

            // Hent spillerens inventory
            if (Game.inventory.Use(itemName))
            {
                // . Grapping the current location from the context data
                current_location = context.GetCurrent();
                current_location.Welcome();
                return;
            }
        }
    }
}