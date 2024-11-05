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

namespace Where_did_Bob_Go_VA.NPC_NS
{

    public class NPC
    {
        public string Place;
        //public Dialog_Tree;
        public bool Visibility;
        public bool Warningsigns;
        public string Name;
        public uint Age;
        public char Gender;

        public bool SuicideRisk(bool warningSigns)
        {
            // Reads the imput from console
            Console.ReadLine();
            if (warningSigns)
            {
                Console.WriteLine("This person does have warning signs and should seek help.");
                return true;
                // Return true if there are warning signs
            }
            else
            {
                Console.WriteLine("This person does not show any warning signs.");
                return false;
                // Return false if there are no warning signs
            }
        }

        public void StartConversation()
        {
            // Short term code, to test if our conversation works in the first place, Gonna be revised later on
            Console.WriteLine("Starting conversation");
            Console.WriteLine("1. Greetings friend, How are you doing today?");
            Console.WriteLine("2. Sup nerd hows it hangin?");
            Console.WriteLine("3. Nevermind, i got somewhere else to be!");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine($"I am doign very well thank you, What are you doing today?.");
                    break;
                case "2":
                    Console.WriteLine("Im Skibidi Rizz Fam, Whats the sitch?");
                    break;
                case "3":
                    Console.WriteLine("Allrighty then, have a good day then");
                    break;
                default:
                    Console.WriteLine("I don't understand that....");
                    break;
            }
        }
        public void StopConversation()
        {
            string choice = Console.ReadLine();

            if (choice == "3")
            {
                return;
            }
        }

        public void UseMonocle(Moncle monocle)
        {

        }

        public void Identifiers()
        {
            //string;
        }
        public bool GuessInput()
        {
            Console.WriteLine("Does the NPC show warning signs? (yes/no)");
            string guess = Console.ReadLine();
            return guess?.ToLower() == "yes";
        }

        public bool GuessCheck(bool guess)
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
        }
    }
}

