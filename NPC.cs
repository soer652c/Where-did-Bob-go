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
using Where_did_Bob_Go_VA.Item;

namespace Where_did_Bob_Go_VA.NPC_NS
{
    public class NPC
    {
        public string Place;
        public Dialog_Tree DialogTree;
        public bool Visibility;
        public bool Warningsigns;
        public string Name;
        public uint Age;
        public char Gender;
        private int choice;

        public bool SuicideRisk(bool warningSigns)
        {
            Console.ReadLine();
            if (warningSigns)
            {
                Console.WriteLine("This person does have warning signs and should seek help.");
                return true;
            }
            else
            {
                Console.WriteLine("This person does not show any warning signs.");
                return false;
            }
        }

        public void StartConversation()
        {
            Console.WriteLine("Starting conversation");
            Console.WriteLine("1. Greetings friend, How are you doing today?");
            Console.WriteLine("2. Sup nerd hows it hangin?");
            Console.WriteLine("3. Nevermind, I got somewhere else to be!");

            string input = Console.ReadLine();

            // 
            if (int.TryParse(input, out choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("I am doing very well thank you, What are you doing today?");
                        break;
                    case 2:
                        Console.WriteLine("I'm Skibidi Rizz Fam, What's the sitch?");
                        break;
                    case 3:
                        Console.WriteLine("Alrighty then, have a good day then");
                        break;
                    default:
                        Console.WriteLine("I don't understand that....");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        public string StopConversation()
        {
            if (choice == 3)
            {
                return Place;
            }
            else
            {
                return null;
            }
        }

        public void UseMonocle(Monocle monocle)
        {
            // 
        }

        public void Identifiers()
        {
            string identifier;
            
        }

        public bool GuessInput(bool warningsigns)
        {
            string guess = Console.ReadLine();
            return warningsigns;
        }

        public bool GuessCheck(bool guess)
        {
            if (guess)
            {
                Console.WriteLine("Guess is true.");
            }
            return guess;
        }
    }
}
