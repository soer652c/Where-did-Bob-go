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
            Change_TextBox_Main("Welcome to \"Where did Bob go?!\" \n\nA text-based narrative game where every word carries weight, \nwhere every choice could save a life, and you will learn through out your journey.\n\nInspired by the classic World of ZUUL \nThis game takes you on an emotional journey through this mysterious town. \nWhere your sharp mind and empathetic heart will be your greatest tools.");
            Change_TextBox_Options("Press Enter...");
            Update_GUI();
            Console.ReadLine(); // når man trykker enter, så går den videre til næste del af teksten
            Update_TextBox_Main("The Story of the game.\n\nYou’ve just arrived to the town shrouded in secrets.\nYou’ll meet 12 unique people each with their own stories and challenges.\nSome may hold clues to what the person is struggling with. \n\nIt’s up to you to connect with them ask the right questions and decide how best to help.");
            Console.ReadLine();
            Update_TextBox_Main("But be warned: not everyone needs saving, and not everyone can be saved");
            Console.ReadLine();
            Update_TextBox_Main("How to Play \n\nWhere did Bob go is a text-based terminal game.\nYou’ll explore the town and interact with the person entirely through text commands.\n\nYour choices will shape the story as :  \n - as you talk with different people. \n - as you navigate through dialogues.\n - and as you have to guess their level of suicide-risk. \n\nYou do so by typing guess name of person and their level. \nTheir level can either be High, Moderate or None. \nIf you guessed the rigth level the person will become invisubal");
            Console.ReadLine();
            Update_TextBox_Main("Here's how it works:\n\n1. Navigate the World: \nUse simple text commands like 'go outside' to move through the game’s location\nExplore key areas like the school or park, each holding unique characters and clues.\n\nThere will be several food-items shown on differnt locations. \nThese items can give you an extra life type use and then the item.\n\n\n" + "2. Engage in Dialogue:\n\nWhen you meet an person initiate a conversation with commands like “talk” or “leave”. \nChoose the responses by typing 1, 2, or 3 this steer the conversation."); 
            Console.ReadLine();
            Update_TextBox_Main("3. Gather Clues:\n\nPay close attention to the people words and behavior. \nSubtle hints could reveal their emotional state.\n\n4. Make Critical Choices:\nEach decision affects the story. Will you dig deeper, or let things slide ? \nSome paths may close forever depending on your responses.");
            Console.ReadLine();
            Update_TextBox_Main("Why It Matters : \n\nThe towns inhabitants have lives complex similar to the world around them. \nBy choosing the right words and actions you could make a real difference,\nor miss the chance entirely. \n\nWill you be the one to help those who need it the most? \nOr will the weight of your choices leave unanswered questions behind?");
            Console.ReadLine();
            Update_TextBox_Main("The Journey Begins... \n\nThey are waiting... \n\nType your first command and step into a story of mystery, connection, and empathy.\n\n\nWhere did Bob go? \nThe answer is in your hands.");
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