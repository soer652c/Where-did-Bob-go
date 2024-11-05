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

namespace Where_did_Bob_Go_VA.World_NS
{


    // GUI
    // This class is responsible for the graphical representation on the terminal, using ASCII.
    public class GUI
    {
        public void DisplayGuessResult(NPC npc)
        {
            bool guess = npc.GuessInput();
            bool result = npc.GuessCheck(guess);
            Console.WriteLine(result ? "Du har gættet rigtigt!" : "Du har gættet forkert.");
        }
        // Properties.

        // main_text_string
        



        // Constructor
        public GUI()
        {
            // .

        }


        // Methodes

    }


}
