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
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Where_did_Bob_Go_VA.NPC_NS
{

    public class NPC
    {
        public string Place;
        public Dialog_Tree;
        public bool NPCvisibility;
        public bool NPCwarningsigns;
        public string NPCname;
        public uint NPCage;
        public char NPCgender;
        public string[] NPCidentifiers;
        public string NPCID;

        public NPC(string name)
        {
            // .
            NPCname = name;
        }

        //public bool SuicideRisk(bool warningSigns)
        //{
        //    // Reads the imput from console
        //    Console.ReadLine();
        //    if (warningSigns)
        //    {
        //        Console.WriteLine("This person does have warning signs and should seek help.");
        //        return true;
        //        // Return true if there are warning signs
        //    }
        //    else
        //    {
        //        Console.WriteLine("This person does not show any warning signs.");
        //        return false;
        //        // Return false if there are no warning signs
        //    }
        //}

        public void StartConversation()
        {
            string[] TextBox = { "1. Greetings friend, How are you doing today?", "2. Sup nerd hows it hangin?", "3. Nevermind, i got somewhere else to be!" };
            Update_TextBox_Main(TextBox);
            // Short term code, to test if our conversation works in the first place, Gonna be revised later on


            String[] Textbox = { "I am doign very well thank you, What are you doing today?.", "Im Skibidi Rizz Fam, Whats the sitch?" };
            Update_TextBox_Options(TextBox);

        }
        //private void StopConversation()
        //    {

        //    }

        //public void UseMonocle(Moncle monocle)
        //{

        //}

        private void NPC_identifiers(string NPCName, int NPCage, string NPCgender)
        {

        }

        public bool GuessInput()
        {
            Console.WriteLine("Does the NPC show warning signs? (yes/no)");
            string guess = Console.ReadLine();
            return guess?.ToLower() == "yes";
        }

        /*public bool GuessCheck(bool guess)
        {
            if (guess == Warningsigns)
            {
                Console.WriteLine("Gæt er korrekt.");
                return true;
            }
            else
            {
                Console.WriteLine("Gæt er forkert.");
                return false;
            }
        }*/


        private bool NPC_visibility(bool visibility)
        // changes depending if the NPC is visible
        {
            // if condition is visible NPC is visible
            // else NPC is hidden
            return visibility;
        }



        private static void PickOption(string userChoice)
        // choice is passed as a parameter
        {
            //string userChoice = Console.ReadLine();
            // Read user input

            PickOption(userChoice);
            // Pass the input to the method

            switch (userChoice)
            {
                case "1":
                    // Handle option 1
                    break;

                case "2":
                    // Handle option 2
                    break;

                case "3":
                    // Handle option 3
                    break;

                default:
                    // Handle invalid input
                    break;
            }
        }

    }

}

