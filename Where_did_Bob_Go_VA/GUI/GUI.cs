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
using static System.Net.Mime.MediaTypeNames;

namespace Where_did_Bob_Go_VA.GUI_NS
{


    // GUI
    // This class is responsible for the graphical representation on the terminal, using ASCII.
    public static class GUI 
    {

        //////////////////   Private Attributes   //////////////////  
        // .   


        /////   TextBox_TopLeft   /////  
        // .   
        private static TextBox TextBox_TopLeft = new TextBox(30, 1, "#", 3, 0);


        /////   TextBox_TopRight   /////  
        // .   
        private static TextBox TextBox_TopRight = new TextBox(20, 1, "#", 3, 0);


        /////   TextBox_Main   /////  
        // .   
        private static TextBox TextBox_Main = new TextBox(100, 20, "#", 3, 1);


        /////   TextBox_Inventory   /////  
        // .   
        private static TextBox TextBox_Inventory = new TextBox(16, 20, "#", 1, 1);


        /////   TextBox_Options   /////  
        // .   
        private static TextBox TextBox_Options = new TextBox(100, 8, "#", 3, 1);






        //////////////////   Constructors   //////////////////  
        // .   


        /////   Constructor   /////   
        // .   
        static GUI()
        {
            // .
            string[] default_text = [" "];


            // .    
            TextBox_TopLeft.Set_Text(default_text);

            // .    
            TextBox_TopRight.Set_Text(default_text);

            // .    
            TextBox_Main.Set_Text(default_text);

            // .    
            TextBox_Inventory.Set_Text(default_text);

            // .    
            TextBox_Options.Set_Text(default_text);


        }





        //////////////////   Private Methods   //////////////////  
        // .   


        /////   Generate_GUI (  )   /////   
        // Pack and prepare the GUI, and the print it out to the Terminal.   
        private static void Generate_GUI( )
        {
            /////   Printing out top text-boxes   /////  
            
            // .    
            string[] TextBox_TopLeft_StringArr = TextBox_TopLeft.Generate_TextBox_ToStrArr();  
            string[] TextBox_TopRight_StringArr = TextBox_TopRight.Generate_TextBox_ToStrArr();  

            // .   
            string[] textBox_Top_StringArr = new string[TextBox_TopLeft.textBox_Height];

            // .  
            if (TextBox_TopLeft.textBox_Height == TextBox_TopRight.textBox_Height)
            {
                // .
                for (int i = 0; i < TextBox_TopLeft.textBox_Height; i++) 
                {
                    textBox_Top_StringArr[i] = TextBox_TopLeft_StringArr[i] + TextBox_TopRight_StringArr[i];
                }
                
                // .
                for (int i = 0; i < TextBox_TopLeft.textBox_Height; i++)
                {
                    // .
                    Console.WriteLine(textBox_Top_StringArr[i]);
                }

            }




            /////   Printing out the main text-box  /////  

            // .    
            // TextBox_Main.Output_TextBox_ToConsole();

            // .    
            string[] TextBox_Main_StringArr = TextBox_Main.Generate_TextBox_ToStrArr();
            string[] TextBox_Inventory_StringArr = TextBox_Inventory.Generate_TextBox_ToStrArr();

            // .   
            string[] textBox_MainPlus_StringArr = new string[TextBox_Main.textBox_Height];

            // .  
            if (TextBox_Main.textBox_Height == TextBox_Inventory.textBox_Height)
            {
                // .
                for (int i = 0; i < TextBox_Main.textBox_Height; i++)
                {
                    textBox_MainPlus_StringArr[i] = TextBox_Main_StringArr[i] + TextBox_Inventory_StringArr[i];
                }

                // .
                for (int i = 0; i < TextBox_Inventory.textBox_Height; i++)
                {
                    // .
                    Console.WriteLine(textBox_MainPlus_StringArr[i]);
                }

            }




            /////   Printing out the options text-box  /////  

            // .    
            TextBox_Options.Output_TextBox_ToConsole();




            return;
        }





        //////////////////   Public Methods   //////////////////  
        // .   


        /////   Update_GUI (  )   /////   
        // Clear the Terminal and calls Generate_GUI( ).   
        public static void Update_GUI( )
        {
            // .   
            Console.Clear();

            // .   
            Generate_GUI();


        }




        /////   Update_TextBox_TopLeft ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopLeft(string[] new_text)
        {
            // .
            Change_TextBox_TopLeft(new_text);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_TopRight ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopRight(string[] new_text)
        {
            // .
            Change_TextBox_TopRight(new_text);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_Main ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Main(string[] new_text)
        {
            // .
            Change_TextBox_Main(new_text);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_Inventory ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Inventory(string[] new_text)
        {
            // .
            Change_TextBox_Inventory(new_text);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_Options ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Options(string[] new_text)
        {
            // .
            Change_TextBox_Options(new_text);

            // .
            Update_GUI();

            // .  
            return;
        }








        /////   Update_TextBox_TopLeft ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopLeft(string new_text)
        {
            // .  
            string[] temp_string = { new_text };

            // .
            Change_TextBox_TopLeft(temp_string);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_TopRight ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopRight(string new_text)
        {
            // .  
            string[] temp_string = { new_text };

            // .
            Change_TextBox_TopRight(temp_string);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_Main ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Main(string new_text)
        {
            // .  
            string[] temp_string = { new_text };

            // .
            Change_TextBox_Main(temp_string);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_Inventory ( string[] )   /////    
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Inventory(string new_text)
        {
            // .  
            string[] temp_string = { new_text };

            // .
            Change_TextBox_Inventory(temp_string);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////   Update_TextBox_Options ( string[] )   /////   
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Options(string new_text)
        {
            // .  
            string[] temp_string = { new_text };

            // .
            Change_TextBox_Options(temp_string);

            // .
            Update_GUI();

            // .  
            return;
        }







        /////   Change_TextBox_TopLeft ( string[] )   /////   
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_TopLeft(string[] new_text)
        {
            // .
            TextBox_TopLeft.Set_Text(new_text);

            // .  
            return;
        }


        /////   Change_TextBox_TopRight ( string[] )   /////   
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_TopRight(string[] new_text)
        {
            // .
            TextBox_TopRight.Set_Text(new_text);

            // .  
            return;
        }


        /////   Change_TextBox_Main ( string[] )   /////   
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Main(string[] new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // .  
            return;
        }


        /////   Change_TextBox_Inventory ( string[] )   /////   
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Inventory(string[] new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // .  
            return;
        }


        /////   Change_TextBox_Options ( string[] )   /////   
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Options(string[] new_text)
        {
            // .
            TextBox_Options.Set_Text(new_text);

            // .  
            return;
        }







    }


}
