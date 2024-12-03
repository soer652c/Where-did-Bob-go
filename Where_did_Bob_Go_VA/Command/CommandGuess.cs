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

        public Space current_location;

        public NPC current_NPC;

        public CommandGuess()
        {
            description = "Makes a guess their risico level.";

            command_use_text = new string[3];
            command_use_text[0] = "guess [name] None";
            command_use_text[1] = "guess [name] Moderate";
            command_use_text[2] = "guess [name] High";
        }

        public void Execute(Context context, string commandName, string[] args)
        {
            current_location = context.GetCurrent();

            if (args.Length == 0 || args.Length != 2)
            {
                Console.WriteLine("Please specify the name AND their risk");
                return;
            }


            string npcName = args[0];
            // NPC npc = Game.npcList.FirstOrDefault(n => n.NPCname.Equals(npcName, StringComparison.OrdinalIgnoreCase) && n.Place == context.CurrentRoom);


            if (npcName == null)
            {
                Console.WriteLine($"Nobody is named {npcName} is in this room.");
                return;
            }
            

            if( (false == (current_location.CheckFor_NPC(npcName))) )  // Gets NPC from NPCMap in current room by name then outputs fetced NPC
            {
                Console.WriteLine($"Nobody is named {npcName} is in this room. Maybe try a different location");
                return;
            }
            else
            {
                current_NPC = current_location.NPC_Map[npcName]; ;
            }

            switch (args[1])
            {
                case "none":
                case "None":
                    if (("None" == current_NPC.NPC_RiskLevel) || ("none" == current_NPC.NPC_RiskLevel))
                    {
                        Change_TextBox_Main($"{npcName} is at Low risk of suicide. Keep looking for other warning signs.");
                        current_NPC.NPCvisibility = false;
                    }
                    else
                    {
                        Change_TextBox_Main($"Guess is not the right risklevel");
                        Game.player.LoseHealth();
                        Update_GUI();
                    }
                    Change_TextBox_Options("Press Enter...");
                    Update_GUI();
                    break;
                case "moderate":
                case "Moderate":
                    if (("Moderate" == current_NPC.NPC_RiskLevel) || ("moderate" == current_NPC.NPC_RiskLevel))
                    {
                        Change_TextBox_Main($"{npcName} is at Moderate risk of suicide. Pay attention and proceed with care.");
                        current_NPC.NPCvisibility = false;
                    }
                    else
                    {
                        Change_TextBox_Main($"Guess is not the right risklevel");
                        Game.player.LoseHealth();
                        Update_GUI();
                    }
                    Change_TextBox_Options("Press Enter...");
                    Update_GUI();
                    break; 
                case "High":
                case "high":
                    if (("High" == current_NPC.NPC_RiskLevel) || ("high" == current_NPC.NPC_RiskLevel))
                    {
                        Change_TextBox_Main($"{npcName} is at High risk of suicide. You should act immediately to help them.");
                        current_NPC.NPCvisibility = false;
                    }
                    else
                    {
                        Change_TextBox_Main($"Guess is not the right risklevel");
                        Game.player.LoseHealth();
                        Update_GUI();
                    }
                    Change_TextBox_Options("Press Enter...");
                    Update_GUI();
                    break;

                default:
                    Console.WriteLine("Whoops, something was misspelled");
                    return;
                    break;
            }

            Console.ReadLine();

            context.NPCleft();

            (context.GetCurrent()).DisplayRoom();
            return;
        }

        public string GetDescription()
        {
            return "Guess the risk level of an person in the current room.";
        }
    }
} // End of namespace Where_did_Bob_Go_VA.Command_NS
