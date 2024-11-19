using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.Game_NS;
using Where_did_Bob_Go_VA.Item_NS;

namespace Where_did_Bob_Go_VA.Command;
public class CommandUse : BaseCommand, ICommand
{ 
    public string type = "Use";

    // Metode til at udføre "Use"-kommandoen
    public void Execute(Context context, string command, string[] args)
    {
        // Tjek om argumentet er korrekt
        if (GuardEq(args, 1))
        {
            Update_TextBox_Main("Invalid. Please specify an item to use. Item not found");
            return;
        }

        // Hent item-navnet fra argumenterne
        string itemName = args[0];

        // Hent spillerens inventory
        Inventory playerInventory = context.GetPlayerInventory();

        // tjekker om Inventory er null


        // Find itemet i inventory baseret på navnet
        Item itemToUse = playerInventory.ItemList.Find(item => item.Name.Equals(itemName, StringComparison.OrdinalIgnoreCase));

        // Tjek om itemet blev fundet
        if (itemToUse != null)
        {
            // Brug itemet
            playerInventory.Use(itemToUse);
        }
        else
        {
            Update_TextBox_Main($"Item '{itemName}' not found in your inventory.");
        }
    }
}
