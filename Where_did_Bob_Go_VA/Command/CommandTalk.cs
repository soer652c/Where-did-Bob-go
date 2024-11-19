﻿using System;
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
using static Where_did_Bob_Go_VA.Game_NS.Game;

namespace Where_did_Bob_Go_VA.Command_NS
{

    public class CommandTalk : BaseCommand, ICommand
    {
        // .  
        Registry registry;

        // .  
        public NPC ?current_NPC;

        // 
        public CommandTalk(Registry registry)
        {
            this.registry = registry;
            this.description = "Display a help message";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            // . Grapping the current location from the context data
            Space current_location = Game.context.GetCurrent();

            // .  Set the npc name to the first parameter
            string npcName = parameters[0];

            // .  Making a if statement to check if the NPCMap is not empty and if the NPC is visible
            if ( (current_location.NPCMap.Count != 0) && (current_location.NPCMap[npcName].NPCvisibility) )
            {
                // .  Set the current npc to the npc in the NPCMap
                current_NPC = current_location.NPCMap[npcName];

                // .  Use the method Move_to_NPC to initiate the interaction with the NPC
                current_location.Move_to_NPC(npcName);
            }
            else
            {
                // .  Print that the there is no npc in the curren location with said name
                Update_TextBox_Main("There is no one named " + npcName + " here.");
            }
         
        }
    }
}