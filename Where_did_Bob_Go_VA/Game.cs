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

//   
//   
//   
namespace Where_did_Bob_Go_VA
{


    /* Main class for launching the game
     */

    public class Game
    {
        static public World world = new World();
        static public Context context = new Context(world.GetEntry());
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
            registry.Register("help", new CommandHelp(registry));
            registry.Register("talk", new CommandTalk());
            registry.Register("leave", new CommandLeave());
            registry.Register("use", new CommandUse());
            registry.Register("grab", new CommandGrab());
            registry.Register("guess", new CommandGuess());
            registry.Register("Show", new CommandShow());
        }

        public Game(/*string[] args*/)
        {
            Update_TextBox_Main("Welcome to the World of Zuul!");

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
            Update_TextBox_Main("Welcome to Where did Bob go, a text-based narrative game where every word carries weight, and every choice could save a life. \n Inspired by the classic World of ZUUL, this game takes you on an emotional journey through the mysterious town of XXXX \n where your sharp mind and empathetic heart will be your greatest tools."); 
                //første tekst boks
            Console.ReadLine(); // når man trykker enter, så går den videre til næste del af teksten
            Update_TextBox_Main("The Story \r\n You’ve just arrived in XXXX, a quaint town shrouded in secrets. Your mission is to uncover the truth about Bob’s sudden disappearance. Along the way, you’ll meet 12 unique NPCs, each with their own stories and challenges. Some may hold clues about Bob, while others may be struggling with their own personal battles. It’s up to you to connect with them, ask the right questions, and decide how best to help. \r\n But be warned: not everyone needs saving, and not everyone can be saved.\r\n");
            Console.ReadLine();
            Update_TextBox_Main("How to Play \r\n Where did Bob go is a text-based terminal game. You’ll explore XXXX and interact with NPCs entirely through text commands. Your choices will shape the story as you navigate through branching dialogue trees. Here's how it works:\r\nNavigate the World: \r\n Use simple text commands like go outside, to look around to move through the game’s locations.\r\nExplore key areas like the school, park, and bar, each holding unique characters and clues. \r\n Engage in Dialogue:\r\nWhen you meet an NPC, initiate a conversation with commands like “talk” or “leave”. \r\n Dialogue is structured into branching options. Choose from the presented responses by typing 1, 2, or 3 to steer the conversation.\r\nGather Clues:\r\nPay close attention to the NPCs' words and behavior. Subtle hints could reveal their emotional state or lead you closer to Bob’s whereabouts.\r\nMake Critical Choices:\r\n Each decision affects the story. Will you dig deeper, or let things slide? Some paths may close forever depending on your responses.\r\n");
            Console.ReadLine();
            Update_TextBox_Main("Why It Matters \r\n XXXX’s inhabitants have lives as complex as the world around them. By choosing the right words and actions, you could make a real difference – or miss the chance entirely. Will you be the one to find Bob and help those who need it most? Or will the weight of your choices leave unanswered questions behind? \r\n ");
            Console.ReadLine();
            Update_TextBox_Main("The Journey Begins \r\n XXXX is waiting. Type your first command and step into a story of mystery, connection, and empathy. Where did Bob go? The answer is in your hands.\r\n ");
        }
        public void GameOver()
        {
            Update_TextBox_Main("You have lost all your health boohoo");
        }
    }
}