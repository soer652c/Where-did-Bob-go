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
        static private World world;
        static private Context context;
        static public ICommand fallback;
        static public Registry registry;
        static public Inventory inventory;
        static public Player player;

        private static void Game_Setup(NPC_DialogID[] npc_DialogID_Arr)
        {
            world = new World(npc_DialogID_Arr);
            context = new Context(ref world);
            fallback = new CommandUnknown();
            registry = new Registry(context, fallback);
            inventory = new Inventory();
            player = new Player(3);

            InitRegistry();
        }

        private static void InitRegistry()
        {
            registry.Register("quit", new CommandExit());
            registry.Register("go", new CommandGo());
            registry.Register("help", new CommandHelp(ref registry));
            registry.Register("talk", new CommandTalk());
            registry.Register("leave", new CommandLeave(ref registry));
            registry.Register("use", new CommandUse());
            registry.Register("grab", new CommandGrab());
            registry.Register("guess", new CommandGuess());
            registry.Register("show", new CommandShow());
        }

        public Game(NPC_DialogID[] npc_DialogID_Arr)
        {
            Game_Setup(npc_DialogID_Arr);

            Introduction ();
            player.HealthTopLeft();
            world.NPCTopRight();
            inventory.Display_Inventory_Textbox();

            CommandList_Box_Update();
            context.GetCurrent().Welcome();

            while (context.IsDone() == false)
            {
                Console.Write("> ");
                string? line = Console.ReadLine();
                if (line != null)
                    registry.Dispatch(line);
                if (player.Health <= 0)
                {
                    GameOver();
                    break;
                }
                if (context.NPCleft() == 0)
                {
                    Win();
                    break;
                }
            }
        }
        public void Introduction() //laver en metode ved navn Introduction
        {
            Change_TextBox_Main("Welcome to Where did Bob go. \n A text-based narrative game where every word carries weight \n every choice could save a life. \n Inspired by the classic World of ZUUL \n this game takes you on an emotional journey through the mysterious town \n where your sharp mind and empathetic heart will be your greatest tools");
            Change_TextBox_Options("Press Enter...");
            Update_GUI();
            Console.ReadLine(); // når man trykker enter, så går den videre til næste del af teksten
            Update_TextBox_Main("The Story of the game \n You’ve just arrived to the town shrouded in secrets.\n You’ll meet 12 unique people \n each with their own stories and challenges.\n Some may hold clues to what the person is struggling with. \n It’s up to you to connect with them \n ask the right questions \n and decide how best to help");
            Console.ReadLine();
            Update_TextBox_Main("But be warned: not everyone needs saving, and not everyone can be saved");
            Console.ReadLine();
            Update_TextBox_Main("How to Play \n Where did Bob go is a text-based terminal game.\n You’ll explore the town \n and interact with the person entirely through text commands. \n Your choices will shape the story \n as you navigate through dialogues. \n    When you have meet an person and talked to them. \n   You have to guess their level of suisiderisk. \n    you do so by typing guess name of person and their level. \n Their level can either be High, Moderate or None. \n   If you guessed the rigth level the person will become invisubal");
            Console.ReadLine();
            Update_TextBox_Main("Here's how it works:\n 1.Navigate the World: \n Use simple text commands like 'go outside' to look around \n to move through the game’s location \n Explore key areas like the school or park \n each holding unique characters and clues. \n    There will be several food-items shown on differnt locations. \n    These items can give you an extra life \n    type use and then the item"); 
            Console.ReadLine();
            Update_TextBox_Main("Engage in Dialogue:\n When you meet an person \n initiate a conversation with commands like “talk” or “leave”. \n Choose the responses by typing 1, 2, or 3 \n this steer the conversation."); 
            Console.ReadLine();
            Update_TextBox_Main("Gather Clues:\n Pay close attention to the people words and behavior. \n Subtle hints could reveal their emotional state.\n Make Critical Choices:\n Each decision affects the story.Will you dig deeper, or let things slide ? \n Some paths may close forever depending on your responses.");
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
            Update_TextBox_Options("Press 'Q' to quit");
            char choice = Console.ReadKey().KeyChar;
            if (choice == 'Q' || choice == 'q')
            {
                Exit();
            }    
        }

        public void Win()
        {
            Update_TextBox_Main("You have won the game");
            Update_TextBox_Options("Press 'Q' to quit");
            char choice = Console.ReadKey().KeyChar;
            if (choice == 'Q' || choice == 'q')
            {
                Exit();
            }
        }
        
        public void Exit()
        {
            Environment.Exit(0);
        }


        public void CommandList_Box_Update()
        {
            string[] command_Names = registry.GetCommandNames();
            Array.Sort(command_Names);

            List<string> complete_commandList = new List<string>();
            int command_List_length = 0;

            foreach (string commandName in command_Names)
            // Denne overskriver nuværende tekst i comand boxen
            {
                BaseCommand temp_command = (BaseCommand) registry.GetCommand(commandName);
                command_List_length = (temp_command.Get_CommandUse_Text()).Length;
                string[] temp_string = new string[command_List_length];
                temp_string = ((BaseCommand) registry.GetCommand(commandName)).Get_CommandUse_Text();
                for (int i = 0; i < temp_string.Length; i++)
                {
                    complete_commandList.Add(temp_string[i]);
                }
            }

            string[] complete_commandList_strings = new string[complete_commandList.Count];

            complete_commandList_strings = complete_commandList.ToArray();

            Change_TextBox_Commands(complete_commandList_strings);

            return;
        }


    }
}