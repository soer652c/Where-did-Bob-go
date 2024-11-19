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
namespace Where_did_Bob_Go_VA.Game_NS
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

        private static void InitRegistry()
        {
            ICommand cmdExit = new CommandExit();
            registry.Register("exit", cmdExit);
            registry.Register("quit", cmdExit);
            registry.Register("bye", cmdExit);
            registry.Register("go", new CommandGo());
            registry.Register("help", new CommandHelp(registry));
            registry.Register("talk", new CommandTalk(registry));
        }

        public Game(/*string[] args*/)
        {
            Update_TextBox_Main("Welcome to the World of Zuul!");



            InitRegistry();
            context.GetCurrent().Welcome();

            while (context.IsDone() == false)
            {
                Console.Write("> ");
                string? line = Console.ReadLine();
                if (line != null) registry.Dispatch(line);
            }
            Update_TextBox_Main("Game Over 😥");
        }
    }


}