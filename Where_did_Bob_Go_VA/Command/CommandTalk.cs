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

    public class CommandTalk : BaseCommand, ICommand
    {
        // .  Defining the Attribute registry
        //Registry registry;

        // . 
        Space current_location;

        // .  making a second attribute current_NPC, and allowing it to be a Null value
        public NPC ?current_NPC;

        // Making the constructor for the class CommandTalk
        public CommandTalk()
        {
            //this.registry = registry;
            this.description = "This command allows you to interact with a NPC in the current room";

            command_use_text = new string[1];
            command_use_text[0] = "talk [name]";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            // . Grapping the current location from the context data
            Space current_location = context.GetCurrent();

            // .  Set the npc name to the first parameter
            string npcName = parameters[0];

            // .  Making a if statement to check if the NPCMap is not empty and if the NPC is visible
            if ( (current_location.NPC_Map.Count != 0) && current_location.CheckFor_NPC(parameters[0]) && current_location.NPC_Map[npcName].NPCvisibility)
            {
                // .  Set the current npc to the npc in the NPCMap
                current_NPC = current_location.NPC_Map[npcName];

                // .  Use the method Move_to_NPC to initiate the interaction with the NPC
                current_location.Move_to_NPC(context, npcName);
            }
            else
            {
                // .  Print that the there is no npc in the curren location with said name
                Console.WriteLine("There is no one named " + npcName + " here.");
            }
         
        }
    }
}