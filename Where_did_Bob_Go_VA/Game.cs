using System;
using System.Diagnostics;

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
using static System.Runtime.InteropServices.JavaScript.JSType;
using Microsoft.VisualBasic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;

//   
//   
//   
namespace Where_did_Bob_Go_VA
{


    /* Main class for launching the game
     */

    public class Game
    {
        static private World world = new World();
        static private Context context = new Context(world.GetEntry());
        static public ICommand fallback = new CommandUnknown();
        static public Registry registry = new Registry(context, fallback);
        static public Inventory inventory = new Inventory();
        static public Player player = new Player(3);

        private static void InitRegistry()
        {
            ICommand cmdExit = new CommandExit();
            registry.Register("exit", cmdExit);
            registry.Register("quit", cmdExit);
            registry.Register("bye", cmdExit);
            registry.Register("go", new CommandGo());
            registry.Register("help", new CommandHelp(ref registry));
            registry.Register("talk", new CommandTalk());
            registry.Register("leave", new CommandLeave(ref registry));
            registry.Register("use", new CommandUse());
            registry.Register("grab", new CommandGrab());
            registry.Register("guess", new CommandGuess());
            registry.Register("show", new CommandShow());
        }

        public Game(/*string[] args*/)
        {
            Introduction ();
            HealthTopLeft();
            InitRegistry();
            context.GetCurrent().Welcome();

            //Ny context 
            context = new Context(world.GetEntry(), world); //Her har world og context klassen kontakt

            while (context.IsDone() == false)
            {
                Console.Write("> ");
                string? line = Console.ReadLine();
                if (line != null)
                    registry.Dispatch(line);

                HealthTopLeft();

            }
            Update_TextBox_Main("Game Over 😥");
            if (context.NPCleft() == 0)
            {
                Update_TextBox_Main("Tillykke! Du har gennemført spillet");
            }
            if (context.NPCleft() != 0)
            {
                Update_TextBox_Main("Game Over 😥");
            }
        }
        public void Introduction() //laver en metode ved navn Introduction
        {
            Update_TextBox_Main("Welcome to Where did Bob go. \n A text-based narrative game where every word carries weight \n every choice could save a life. \n Inspired by the classic World of ZUUL \n this game takes you on an emotional journey through the mysterious town \n where your sharp mind and empathetic heart will be your greatest tools"); 
            Console.ReadLine(); // når man trykker enter, så går den videre til næste del af teksten
            Update_TextBox_Main("The Story of the game \n You’ve just arrived to the town shrouded in secrets.\n You’ll meet 12 unique NPCs \n each with their own stories and challenges.\n Some may hold clues to what the NPC's are struggling with. \n It’s up to you to connect with them \n ask the right questions \n and decide how best to help");
            Console.ReadLine();
            Update_TextBox_Main("But be warned: not everyone needs saving, and not everyone can be saved");
            Console.ReadLine();
            Update_TextBox_Main("How to Play \n Where did Bob go is a text-based terminal game.\n You’ll explore the town \n and interact with NPCs entirely through text commands. \n Your choices will shape the story \n as you navigate through dialogues.");
            Console.ReadLine();
            Update_TextBox_Main("Here's how it works:\n 1.Navigate the World: \n Use simple text commands like 'go outside' \n to look around \n to move through the game’s location \n Explore key areas like the school or park \n each holding unique characters and clues."); 
            Console.ReadLine();
            Update_TextBox_Main("Engage in Dialogue:\n When you meet an NPC \n initiate a conversation with commands like “talk” or “leave”. \n Choose the responses by typing 1, 2, or 3 \n this steer the conversation."); 
            Console.ReadLine();
            Update_TextBox_Main("Gather Clues:\n Pay close attention to the NPCs' words and behavior. \n Subtle hints could reveal their emotional state.\n Make Critical Choices:\n Each decision affects the story.Will you dig deeper, or let things slide ? \n Some paths may close forever depending on your responses.");
            Console.ReadLine();
            Update_TextBox_Main("Why It Matters \n the towns inhabitants have lives as complex as the world around them. \n By choosing the right words and actions \n you could make a real difference \n or miss the chance entirely. \n Will you be the one to help those who need it the most? \n Or will the weight of your choices leave unanswered questions behind?");
            Console.ReadLine();
            Update_TextBox_Main("The Journey Begins \n they are waiting. \n Type your first command \n and step into a story of mystery, connection, and empathy.\n  Where did Bob go? The answer is in your hands.");
            Console.ReadLine();
            Update_TextBox_Main("Enjoy the Game");
            Console.ReadLine();
        }
        public void GameOver()
        {
            Update_TextBox_Main("You have lost all your health boohoo");
        }

        public void HealthTopLeft()
        {
            string playerString = player.Health.ToString();
            Change_TextBox_TopLeft("Lives: " + playerString);
        }
    }
}