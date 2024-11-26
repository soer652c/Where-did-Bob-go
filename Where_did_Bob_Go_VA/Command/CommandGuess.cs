using System;
using System.Diagnostics;
using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.Game_NS;
using Where_did_Bob_Go_VA.GUI_NS;
using Where_did_Bob_Go_VA.Item_NS;
using Where_did_Bob_Go_VA.NPC_NS;
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;
using Where_did_Bob_Go_VA.Player_NS;
using Where_did_Bob_Go_VA.Proc_Gen_NS;
using Where_did_Bob_Go_VA.World_NS;

using static Where_did_Bob_Go_VA.GUI_NS.GUI;


namespace Where_did_Bob_Go_VA.Command_NS
{

    public class CommandGuess : BaseCommand, ICommand
    {
        //private Context context;

        Space current_location;

        NPC current_NPC;

        public CommandGuess(Registry registry)
        {
            //this.context = context;
        }

        public void Execute(Context context, string commandName, string[] args)
        {
            current_location = Game.context.GetCurrent();

            // current_NPC = CommandTalk.current_NPC;

            if (args.Length == 0 || args.Length != 2)
            {
                Update_TextBox_Main("Please specify the name AND risk value");
                return;
            }

            string npcName = args[0];
            // NPC npc = Game.npcList.FirstOrDefault(n => n.NPCname.Equals(npcName, StringComparison.OrdinalIgnoreCase) && n.Place == context.CurrentRoom);

            if (npcName == null)
            {
                Update_TextBox_Main($"No NPC named {npcName} is in this room.");
                return;
            }
           
            if(false == (current_location.NPCMap.TryGetValue(npcName, out current_NPC)))  // Gets NPC from NPCMap in current room by name then outputs fetced NPC
            {
                Update_TextBox_Main($"No NPC named {npcName} is in this room. Maybe try a different location");
                return;
            }


            if (false == (args[1] == current_NPC.NPCriskLevel))
            {
                Update_TextBox_Main($"Guess is not the right risklevel");
                return;
            }

            switch (args[1])
            {
                case "low":
                case "Low":
                    Update_TextBox_Main($"{npcName} is at Low risk of suicide. Keep looking for other warning signs.");
                    break;
                case "medium":
                case "Medium":
                    Update_TextBox_Main($"{npcName} is at Medium risk of suicide. Pay attention and proceed with care.");
                    break;
                case "High":
                case "high":
                    Update_TextBox_Main($"{npcName} is at High risk of suicide. You should act immediately to help them.");
                    break;
            }
            current_NPC.NPCvisibility = false;
            return;
        }

        public string GetDescription()
        {
            return "Guess the risk level of an NPC in the current room.";
        }
    }
} // End of namespace Where_did_Bob_Go_VA.Command_NS
