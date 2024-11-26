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

using static Where_did_Bob_Go_VA.GUI_NS.GUI;


namespace Where_did_Bob_Go_VA
{

    public class Main_Class
    {


        public Main_Class() { }




        // static void Main(string[] arg)
        // Jetbrain just straight up use the commands "dotnet build" and "dotnet run".
        // In the dotnet frame-work the compiler looks for any class methods called "public static void Main",
        // and uses is the Main, to control the order of sekvenses run. 
        public static void Main()
        {
            
            // . 
            Game game = new Game();

        }

    }


}


