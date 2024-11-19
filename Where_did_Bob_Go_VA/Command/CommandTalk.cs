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
            // .  
            Space current_location = Game.context.GetCurrent();

            // .  
            string npcName = parameters[0];

            // .  
            if ( (current_location.NPCMap.Count != 0) && (current_location.NPCMap[npcName].NPCvisibility) )
            {
                // .  
                current_NPC = current_location.NPCMap[npcName];
                
                // .  
                current_location.Move_to_NPC(npcName);
            }
            else
            {
                // .  
                Update_TextBox_Main("There is no one named " + npcName + " here.");
            }
         
        }
    }
}