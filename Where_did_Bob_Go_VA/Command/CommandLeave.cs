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

    public class CommandLeave : BaseCommand, ICommand
    {
        Registry registry;

        // 
        public CommandLeave(ref Registry registry)
        {
            this.registry = registry;
            this.description = "Lets you leave a conversation with a person.";

            command_use_text = new string[1];
            command_use_text[0] = "leave";
        }

        public void Execute(Context context, string command, string[] parameters)
        {
            // registry. får vi fra vores Game.cs fil
            // GetCommand trækker commandedn leave
            // placeholder trækker fra CommandTalk, som viser hvilken NPC man snakker med
            // så kører den StopConversation() for at afslutte samtalen

            // ((CommandTalk)Game.registry.GetCommand("talk"))  
            // .  

            // ((CommandTalk)Game.registry.GetCommand("talk")).current_NPC.StopConversation();  
            // .  

            // . 
            if (((CommandTalk)registry.GetCommand("talk")).current_NPC != null)
            {
                // .  
                ((CommandTalk)registry.GetCommand("talk")).current_NPC.StopConversation();
            }
            else
            {
                // .  
                throw new Exception("Not currently talking with an NPC with that name.");
            }
        }
    }
}
