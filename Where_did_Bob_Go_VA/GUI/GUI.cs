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
using System.Diagnostics;

namespace Where_did_Bob_Go_VA.GUI_NS
{


    // GUI
    // This class is responsible for the graphical representation on the terminal, using ASCII.
    public static class GUI 
    {

        ////////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Private Attributes          /////////////////////////   
        ////////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      


        /////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_TopBoxes_Height        ///////////////   
        private const uint TextBox_TopBoxes_Height = 1;

        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_TopBoxes_Spacing_TopBottom        ///////////////   
        private const uint TextBox_TopBoxes_Spacing_TopBottom = 0;

        /////////////////////////////////////////////////////////////    
        ///////////////        TextBox_TopLeft        ///////////////   
        private static TextBox TextBox_TopLeft = new TextBox(20, TextBox_TopBoxes_Height, "||", "##", 1, TextBox_TopBoxes_Spacing_TopBottom);

        ///////////////////////////////////////////////////////////////    
        ///////////////        TextBox_TopMiddle        ///////////////  
        private static TextBox TextBox_TopMiddle = new TextBox(50, TextBox_TopBoxes_Height, "||", "##", 1, TextBox_TopBoxes_Spacing_TopBottom);

        //////////////////////////////////////////////////////////////    
        ///////////////        TextBox_TopRight        ///////////////    
        private static TextBox TextBox_TopRight = new TextBox(20, TextBox_TopBoxes_Height, "||", "##", 1, TextBox_TopBoxes_Spacing_TopBottom);



        ////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_MiddleBoxes_Height        ///////////////  
        private const uint TextBox_MiddleBoxes_Height = 16;

        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_MiddleBoxes_Spacing_TopBottom        ///////////////
        private const uint TextBox_MiddleBoxes_Spacing_TopBottom = 2;

        //////////////////////////////////////////////////////////    
        ///////////////        TextBox_Main        ///////////////   
        private static TextBox TextBox_Main = new TextBox(78, TextBox_MiddleBoxes_Height, "||", "##", 1, TextBox_MiddleBoxes_Spacing_TopBottom, "Main");

        //////////////////////////////////////////////////////////////    
        ///////////////        TextBox_Commands        ///////////////    
        private static TextBox TextBox_Commands = new TextBox(20, TextBox_MiddleBoxes_Height, "||", "##", 1, TextBox_MiddleBoxes_Spacing_TopBottom, "Commands");



        ////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_BottomBoxes_Height        ///////////////    
        private const uint TextBox_BottomBoxes_Height = 8;

        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_BottomBoxes_Spacing_TopBottom        ///////////////    
        private const uint TextBox_BottomBoxes_Spacing_TopBottom = 1;

        /////////////////////////////////////////////////////////////    
        ///////////////        TextBox_Options        ///////////////
        private static TextBox TextBox_Options = new TextBox(78, TextBox_BottomBoxes_Height, "||", "##", 1, TextBox_BottomBoxes_Spacing_TopBottom, "Options");

        ///////////////////////////////////////////////////////////////    
        ///////////////        TextBox_Inventory        ///////////////
        private static TextBox TextBox_Inventory = new TextBox(20, TextBox_BottomBoxes_Height, "||", "##", 1, TextBox_BottomBoxes_Spacing_TopBottom, "Inventory");





        ///////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Public Attributes          /////////////////////////   
        ///////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      




        //////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Constructors          /////////////////////////   
        //////////////////////////////////////////////////////////////////////////////////   
        //   
        //      


        /////////////////////////////////////////////////////    
        ///////////////        GUI ( )        ///////////////    
        static GUI()
        {
            // .
            string[] default_text = [" "];


            // .    
            TextBox_TopLeft.Set_Text(default_text);

            // .    
            TextBox_TopMiddle.Set_Text(default_text);

            // .    
            TextBox_TopRight.Set_Text(default_text);

            // .    
            TextBox_Main.Set_Text(default_text);

            // .    
            TextBox_Commands.Set_Text(default_text);

            // .    
            TextBox_Options.Set_Text(default_text);

            // .    
            TextBox_Inventory.Set_Text(default_text);


        }





        /////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Private Methods          /////////////////////////   
        /////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      


        ///////////////////////////////////////////////////////////////    
        ///////////////        Generate_GUI (  )        ///////////////     
        // Pack and prepare the GUI, and the print it out to the Terminal.   
        private static void Generate_GUI( )
        {
            /////   Printing out top text-boxes   /////  
            
            // .    
            string[] TextBox_TopLeft_StringArr = TextBox_TopLeft.Generate_TextBox_ToStrArr();   
            string[] TextBox_TopMiddle_StringArr = TextBox_TopMiddle.Generate_TextBox_ToStrArr();   
            string[] TextBox_TopRight_StringArr = TextBox_TopRight.Generate_TextBox_ToStrArr();  

            // .   
            string[] textBox_TopPlus_StringArr = new string[TextBox_TopLeft.textBox_Height];

            // .  
            if ( (TextBox_TopLeft.textBox_Height == TextBox_TopMiddle.textBox_Height) && (TextBox_TopMiddle.textBox_Height == TextBox_TopRight.textBox_Height) )
            {
                // .
                for (int i = 0; i < TextBox_TopLeft.textBox_Height; i++) 
                {
                    textBox_TopPlus_StringArr[i] = TextBox_TopLeft_StringArr[i] + TextBox_TopMiddle_StringArr[i] + TextBox_TopRight_StringArr[i];
                }

                // .
                for (int i = 0; i < TextBox_TopLeft.textBox_Height; i++)
                {
                    // .
                    Console.WriteLine(textBox_TopPlus_StringArr[i]);
                }

            }
            else
            {
                // .    
                throw new Exception();
            }




            /////   Printing out the main text-box  /////  

            // .    
            string[] TextBox_Main_StringArr = TextBox_Main.Generate_TextBox_ToStrArr();
            string[] TextBox_Commands_StringArr = TextBox_Commands.Generate_TextBox_ToStrArr();

            // .   
            string[] textBox_MainPlus_StringArr = new string[TextBox_Main.textBox_Height];

            // .  
            if (TextBox_Main.textBox_Height == TextBox_Commands.textBox_Height)
            {
                // .
                for (int i = 0; i < TextBox_Main.textBox_Height; i++)
                {
                    textBox_MainPlus_StringArr[i] = TextBox_Main_StringArr[i] + TextBox_Commands_StringArr[i];
                }

                // .
                for (int i = 0; i < TextBox_Commands.textBox_Height; i++)
                {
                    // .
                    Console.WriteLine(textBox_MainPlus_StringArr[i]);
                }

            }
            else
            {
                // .    
                throw new Exception();
            }




            /////   Printing out the options text-box  /////  

            // .    
            string[] TextBox_Options_StringArr = TextBox_Options.Generate_TextBox_ToStrArr();
            string[] TextBox_Inventory_StringArr = TextBox_Inventory.Generate_TextBox_ToStrArr();

            // .   
            string[] textBox_OptionsPlus_StringArr = new string[TextBox_Options.textBox_Height];

            // .  
            if (TextBox_Options.textBox_Height == TextBox_Inventory.textBox_Height)
            {
                // .
                for (int i = 0; i < TextBox_Options.textBox_Height; i++)
                {
                    textBox_OptionsPlus_StringArr[i] = TextBox_Options_StringArr[i] + TextBox_Inventory_StringArr[i];
                }

                // .
                for (int i = 0; i < TextBox_Inventory.textBox_Height; i++)
                {
                    // .
                    Console.WriteLine(textBox_OptionsPlus_StringArr[i]);
                }

            }
            else
            {
                // .    
                throw new Exception();
            }



            return;
        }





        ////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Public Methods          /////////////////////////   
        ////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      


        /////////////////////////////////////////////////////////////    
        ///////////////        Update_GUI (  )        ///////////////    
        // Clear the Terminal and calls Generate_GUI( ).   
        public static void Update_GUI( )
        {

            // "Clear()" og "\x1b[3J" Clears the terminal even on Windows Shell.   
            Console.Clear();
            Console.WriteLine("\x1b[3J");

            // .   
            Generate_GUI();


        }




        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopLeft ( string[] )        ///////////////    
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


        //////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopRight ( string[] )        ///////////////    
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


        //////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Main ( string[] )        ///////////////     
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


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////         Update_TextBox_Commands ( string[] )        ///////////////    
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Commands(string[] new_text)
        {
            // .
            Change_TextBox_Commands(new_text);

            // .
            Update_GUI();

            // .  
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Options ( string[] )        ///////////////    
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








        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopLeft ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
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


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopRight ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
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


        ////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Main ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
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


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Commands ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Commands(string new_text)
        {
            // .  
            string[] temp_string = { new_text };

            // .
            Change_TextBox_Commands(temp_string);

            // .
            Update_GUI();

            // .  
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Options ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
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







        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopLeft ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_TopLeft(string[] new_text)
        {
            // .
            TextBox_TopLeft.Set_Text(new_text);

            // .  
            return;
        }


        //////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopRight ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_TopRight(string[] new_text)
        {
            // .
            TextBox_TopRight.Set_Text(new_text);

            // .  
            return;
        }


        //////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Main ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Main(string[] new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // .  
            return;
        }


        //////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Commands ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Commands(string[] new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // .  
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Options ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Options(string[] new_text)
        {
            // .
            TextBox_Options.Set_Text(new_text);

            // .  
            return;
        }








        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopLeft ( string )        ///////////////    
        // Takes in a string array, converts the string into string[], and changes the text of a the textbox.   
        public static void Change_TextBox_TopLeft(string new_text)
        {
            // .
            TextBox_TopLeft.Set_Text(new_text);

            // .  
            return;
        }


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopRight ( string )        ///////////////    
        // Takes in a string array, converts the string into string[], and changes the text of a the textbox.   
        public static void Change_TextBox_TopRight(string new_text)
        {
            // .
            TextBox_TopRight.Set_Text(new_text);

            // .  
            return;
        }


        ////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Main ( string )        ///////////////    
        // Takes in a string array, converts the string into string[], and changes the text of a the textbox.   
        public static void Change_TextBox_Main(string new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // .  
            return;
        }


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Commands ( string )        ///////////////    
        // Takes in a string array, converts the string into string[], and changes the text of a the textbox.   
        public static void Change_TextBox_Commands(string new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // .  
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Options ( string )        ///////////////    
        // Takes in a string array, converts the string into string[], and changes the text of a the textbox.   
        /// <summary>
        /// <c> Change_TextBox_Options : </c> <br/>  
        /// Generates the combined/final string-array that contains the complete Textbox. <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        ///  <br/>  
        ///  <br/>  
        ///  <br/>  
        ///  <br/>
        ///  
        ///  <list type="bullet|number|table">  
        ///  
        ///     <listheader>  
        ///         <term> Textbox </term>  
        ///         <description>  
        ///         The box that will be printed/generated, based on the attributes inside the TextBox Object. 
        ///         </description>  
        ///     </listheader>  
        ///     
        ///     <item>  
        ///         <term> Textbox Text </term>  
        ///         <description>  
        ///         The text that will be inside the Textbox, and stored in the TextBox Object.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> GUI </term>  
        ///         <description>  
        ///         Normally it would mean the "Graphical User Interface", but this is more like a "CLI" (Commmand-Line Interface).  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Change Textbox </term>  
        ///         <description>  
        ///         Preparing the Textbox with a new Text, so it is ready for when the "Update GUI" gets called.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update Textbox </term>  
        ///         <description>  
        ///         Changes the Textbox Text.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         .  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     
        ///     // . 
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        public static void Change_TextBox_Options(string new_text)
        {
            // .
            TextBox_Options.Set_Text(new_text);

            // .  
            return;
        }








    }


}
