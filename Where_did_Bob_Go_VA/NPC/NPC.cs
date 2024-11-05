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
using System.Security.Cryptography.X509Certificates;

namespace Where_did_Bob_Go_VA.NPC_NS
{

public class NPC
    {
        public string Place;
        public Dialog_Tree;
        public bool Visibility;
        public bool Warningsigns;
        public string Name;
        public string Age;
        public char Gender;

    public static bool SuicideRisk(bool warningSigns)
        {

        }
       

    public void StartConversation(NPCInRoom)
            {
            if (NPCList.Count > 0)
            {
                // Short term code, to test if our conversation works in the first place. Gonna be revised later on
                Console.WriteLine("Starting conversation");
                Console.WriteLine("1. Greetings friend, how are you doing today?");
                Console.WriteLine("2. Sup nerd, how's it hangin'?");
                Console.WriteLine("3. Nevermind, I got somewhere else to be!");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("I am doing very well, thank you! What are you doing today?");
                        break;
                    case "2":
                        Console.WriteLine("I'm Skibidi Rizz fam, what's the sitch?");
                        break;
                    case "3":
                        Console.WriteLine("Alrighty then, have a good day!");
                        break;
                    default:
                        Console.WriteLine("I don't understand that....");
                        break;
                }
            }
            else
            {
                Console.WriteLine("There is no NPC in this room.");
            }
        }

    public void StopConversation()
            {
            
            }

    public void UseMonocle(Monocle)
            {

            }

    public void Identifiers()
        {
        public string NPCName()
            {
              string name = "Jenny Simons";
              return name;
            }
                // Still a placeholder

        public string NPCAge()
            {
              string age = "45";
              return age;
            }
                // Also a placeholder 
        }

    public bool GuessImput(Warningsigns)
            {
        Guess = Console.ReadLine();
                    {

                    }

    public bool GuessCheck(Guess)
            {
                if Guess = True
                    Console.WriteLine("Fook yeh dude");
                else
                    Console.WriteLine("Nah dude, that aint it");
            }
        }

    }
