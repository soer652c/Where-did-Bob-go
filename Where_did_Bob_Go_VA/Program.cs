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
            Console.WriteLine("Hello. Yeah, I an just testing.");


            // .
            TextBox TestBox_1 = new TextBox( 60, 15, "#", 1, 1);


            // . 
            string[] text = [ "Hey you there ", "...", ".....", ".... You Nerd! XD" ];


            
            // . 
            string[] box_string = new string[100]; 
            //box_string = TestBox_1.Generate_TextBox_strArr();
            //TestBox_1.Generate_TextLines(ref box_string, 0);
            /*for (int i = 0; i < box_string.Length; i++)
            {
                Console.WriteLine(box_string[i]);
            }
            */


            // .
            TestBox_1.Set_Text(text);
            Console.WriteLine( TestBox_1.Generate_TextBox_ToStr() );


            Console.ReadLine();


            // . 
            Game game = new Game();



        }

    }


}


