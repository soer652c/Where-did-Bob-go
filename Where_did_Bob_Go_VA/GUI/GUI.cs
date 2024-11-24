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



        ///////////////////////////////////////////////////////////////////    
        ///////////////        GUI_TopPart_StringArr        ///////////////
        private static string[] GUI_TopPart_StringArr;

        //////////////////////////////////////////////////////////////////////    
        ///////////////        GUI_MiddlePart_StringArr        ///////////////
        private static string[] GUI_MiddlePart_StringArr;

        //////////////////////////////////////////////////////////////////////    
        ///////////////        GUI_BottomPart_StringArr        ///////////////
        private static string[] GUI_BottomPart_StringArr;





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
            // .  
            Generate_GUI_TopPart();

            // .   
            Generate_GUI_MiddlePart();

            // .  
            Generate_GUI_BottomPart();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_GUI_TopPart (  )        ///////////////     
        // Pack and prepare the GUI, and the print it out to the Terminal.   
        private static void Generate_GUI_TopPart()
        {
            // .    
            string[] TextBox_TopLeft_StringArr = TextBox_TopLeft.Generate_TextBox_ToStrArr();
            string[] TextBox_TopMiddle_StringArr = TextBox_TopMiddle.Generate_TextBox_ToStrArr();
            string[] TextBox_TopRight_StringArr = TextBox_TopRight.Generate_TextBox_ToStrArr();

            GUI_TopPart_StringArr = new string[TextBox_TopLeft.textBox_Height];

            //// .  
            //if (GUI_TopPart_StringArr.Length != TextBox_TopLeft.textBox_Height)
            //{
            //    // .   
            //    GUI_TopPart_StringArr = new string[TextBox_TopLeft.textBox_Height];
            //}

            // .  
            if ((TextBox_TopLeft.textBox_Height == TextBox_TopMiddle.textBox_Height) && (TextBox_TopMiddle.textBox_Height == TextBox_TopRight.textBox_Height))
            {
                // .
                for (int i = 0; i < TextBox_TopLeft.textBox_Height; i++)
                {
                    GUI_TopPart_StringArr[i] = TextBox_TopLeft_StringArr[i] + TextBox_TopMiddle_StringArr[i] + TextBox_TopRight_StringArr[i];
                }
            }
            else
            {
                // .    
                throw new Exception();
            }

            // Returns void. 
            return;
        }


        //////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_GUI_MiddlePart (  )        ///////////////     
        // Pack and prepare the GUI, and the print it out to the Terminal.   
        private static void Generate_GUI_MiddlePart()
        {
            // .   
            string[] TextBox_Main_StringArr = TextBox_Main.Generate_TextBox_ToStrArr();
            string[] TextBox_Commands_StringArr = TextBox_Commands.Generate_TextBox_ToStrArr();

            GUI_MiddlePart_StringArr = new string[TextBox_Main.textBox_Height];

            //// .  
            //if (GUI_MiddlePart_StringArr.Length != TextBox_Main.textBox_Height)
            //{
            //    // .   
            //    GUI_MiddlePart_StringArr = new string[TextBox_Main.textBox_Height];
            //}

            // .   
            if (TextBox_Main.textBox_Height == TextBox_Commands.textBox_Height)
            {
                // .
                for (int i = 0; i < TextBox_Main.textBox_Height; i++)
                {
                    GUI_MiddlePart_StringArr[i] = TextBox_Main_StringArr[i] + TextBox_Commands_StringArr[i];
                }
            }
            else
            {
                // .    
                throw new Exception();
            }

            // Returns void. 
            return;
        }


        //////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_GUI_BottomPart (  )        ///////////////     
        // Pack and prepare the GUI, and the print it out to the Terminal.   
        private static void Generate_GUI_BottomPart()
        {
            // .    
            string[] TextBox_Options_StringArr = TextBox_Options.Generate_TextBox_ToStrArr();
            string[] TextBox_Inventory_StringArr = TextBox_Inventory.Generate_TextBox_ToStrArr();

            GUI_BottomPart_StringArr = new string[TextBox_Options.textBox_Height];

            //// .  
            //if (GUI_BottomPart_StringArr.Length != TextBox_Options.textBox_Height)
            //{
            //    // .   
            //    GUI_BottomPart_StringArr = new string[TextBox_Options.textBox_Height];
            //}

            // .  
            if (TextBox_Options.textBox_Height == TextBox_Inventory.textBox_Height)
            {
                // .
                for (int i = 0; i < TextBox_Options.textBox_Height; i++)
                {
                    GUI_BottomPart_StringArr[i] = TextBox_Options_StringArr[i] + TextBox_Inventory_StringArr[i];
                }
            }
            else
            {
                // .    
                throw new Exception();
            }

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////    
        ///////////////        Print_GUI (  )        ///////////////     
        // Pack and prepare the GUI, and the print it out to the Terminal.   
        private static void Print_GUI()
        {
            
            // "Clear()" and "\x1b[3J" Clears the terminal even on Windows Shell.   
            Console.Clear();
            Console.WriteLine("\x1b[3J");



            // .  
            // .  
            if (GUI_TopPart_StringArr == null || GUI_TopPart_StringArr.Length == 0)
            {
                // .
                Generate_GUI_TopPart();

                //
                if (GUI_TopPart_StringArr == null || GUI_TopPart_StringArr.Length == 0)
                {
                    // .    
                    throw new Exception();
                }
            }

            // .   
            if (GUI_TopPart_StringArr != null)
            {
                // .
                for (int i = 0; i < GUI_TopPart_StringArr.Length; i++)
                {
                    Console.WriteLine(GUI_TopPart_StringArr[i]);
                }
            }



            // .   
            // .   
            if (GUI_MiddlePart_StringArr == null || GUI_MiddlePart_StringArr.Length == 0)
            {
                // .
                Generate_GUI_MiddlePart();

                //
                if (GUI_MiddlePart_StringArr == null || GUI_MiddlePart_StringArr.Length == 0)
                {
                    // .    
                    throw new Exception();
                }
            }

            // .   
            if (GUI_MiddlePart_StringArr != null)
            {
                // .
                for (int i = 0; i < GUI_MiddlePart_StringArr.Length; i++)
                {
                    Console.WriteLine(GUI_MiddlePart_StringArr[i]);
                }
            }



            // .  
            // .  
            if (GUI_BottomPart_StringArr == null || GUI_BottomPart_StringArr.Length == 0)
            {
                // .
                Generate_GUI_BottomPart();

                //
                if (GUI_BottomPart_StringArr == null || GUI_BottomPart_StringArr.Length == 0)
                {
                    // .    
                    throw new Exception();
                }
            }

            // .   
            if (GUI_BottomPart_StringArr != null)
            {
                // .
                for (int i = 0; i < GUI_BottomPart_StringArr.Length; i++)
                {
                    Console.WriteLine(GUI_BottomPart_StringArr[i]);
                }
            }



            // Returns void. 
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
            // .   
            Generate_GUI();

            // .   
            Print_GUI();

            // Returns void. 
            return;
        }






        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopLeft ( string[] )        ///////////////    
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopLeft(string[] new_text)
        {
            // .
            Change_TextBox_TopLeft(new_text);

            // . 
            Generate_GUI_TopPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopMiddle ( string[] )        ///////////////    
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopMiddle(string[] new_text)
        {
            // .
            Change_TextBox_TopMiddle(new_text);

            // . 
            Generate_GUI_TopPart();

            // .
            Print_GUI();

            // Returns void. 
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
            Generate_GUI_TopPart();

            // .
            Print_GUI();

            // Returns void. 
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
            Generate_GUI_MiddlePart();

            // .
            Print_GUI();

            // Returns void. 
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
            Generate_GUI_MiddlePart();

            // .
            Print_GUI();

            // Returns void. 
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
            Generate_GUI_BottomPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Inventory ( string[] )        ///////////////    
        // Takes in a string array, changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Inventory(string[] new_text)
        {
            // .
            Change_TextBox_Inventory(new_text);

            // . 
            Generate_GUI_BottomPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }








        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopLeft ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopLeft(string new_text)
        {
            // .
            Change_TextBox_TopLeft(new_text);

            // . 
            Generate_GUI_TopPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopMiddle ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopMiddle(string new_text)
        {
            // .
            Change_TextBox_TopMiddle(new_text);

            // . 
            Generate_GUI_TopPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_TopRight ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_TopRight(string new_text)
        {
            // .
            Change_TextBox_TopRight(new_text);

            // . 
            Generate_GUI_TopPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Main ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Main(string new_text)
        {
            // .
            Change_TextBox_Main(new_text);

            // . 
            Generate_GUI_MiddlePart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Commands ( string )        ///////////////    
        // Takes in a string, converts the string into string[], changes the text of the textbox, and updates the GUI.   
        public static void Update_TextBox_Commands(string new_text)
        {
            // .
            Change_TextBox_Commands(new_text);

            // . 
            Generate_GUI_MiddlePart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Options ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Options : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "Options", and then Updates the Textbox. <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Update_TextBox_Options( "Hello World" );
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Update_TextBox_Options(string new_text)
        {
            // .
            Change_TextBox_Options(new_text);

            // . 
            Generate_GUI_BottomPart();

            // .
            Print_GUI();

            // Returns void. 
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Update_TextBox_Inventory ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Inventory : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "Inventory", and then Updates the Textbox. <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Update_TextBox_Inventory( "Hello World" );
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Update_TextBox_Inventory(string new_text)
        {
            // .
            Change_TextBox_Inventory(new_text);

            // . 
            Generate_GUI_BottomPart();

            // .
            Print_GUI();

            // Returns void. 
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
            Generate_GUI_TopPart();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopMiddle ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_TopMiddle(string[] new_text)
        {
            // .
            TextBox_TopMiddle.Set_Text(new_text);

            // . 
            Generate_GUI_TopPart();

            // Returns void. 
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
            Generate_GUI_TopPart();

            // Returns void. 
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
            Generate_GUI_MiddlePart();

            // Returns void. 
            return;
        }


        //////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Commands ( string[] )        ///////////////    
        // Takes in a string array and changes the text of a the textbox.   
        public static void Change_TextBox_Commands(string[] new_text)
        {
            // .
            TextBox_Commands.Set_Text(new_text);

            // . 
            Generate_GUI_MiddlePart();

            // Returns void. 
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Options ( string[] )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Options : </c> <br/>  
        /// Takes in a string[] and Changes the Text in the Textbox "Options". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_Options( test );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> Each element in the array is its own line, and "\n" are not allowed. </param>  
        /// 
        public static void Change_TextBox_Options(string[] new_text)
        {
            // .
            TextBox_Options.Set_Text(new_text);

            // . 
            Generate_GUI_BottomPart();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Inventory ( string[] )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Inventory : </c> <br/>  
        /// Takes in a string[] and Changes the Text in the Textbox "Inventory". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_Inventory( test );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> Each element in the array is its own line, and "\n" are not allowed. </param>  
        /// 
        public static void Change_TextBox_Inventory(string[] new_text)
        {
            // .
            TextBox_Inventory.Set_Text(new_text);

            // . 
            Generate_GUI_BottomPart();

            // Returns void. 
            return;
        }








        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopLeft ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_TopLeft : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "TopLeft". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_TopLeft( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_TopLeft(string new_text)
        {
            // .
            TextBox_TopLeft.Set_Text(new_text);

            // . 
            Generate_GUI_TopPart();

            // Returns void. 
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopMiddle ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_TopMiddle : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "TopMiddle". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_TopMiddle( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_TopMiddle(string new_text)
        {
            // .
            TextBox_TopMiddle.Set_Text(new_text);

            // . 
            Generate_GUI_TopPart();

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_TopRight ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_TopRight : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "TopRight". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_TopRight( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_TopRight(string new_text)
        {
            // .
            TextBox_TopRight.Set_Text(new_text);

            // . 
            Generate_GUI_TopPart();

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Main ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Main : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "Main". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_Main( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_Main(string new_text)
        {
            // .
            TextBox_Main.Set_Text(new_text);

            // . 
            Generate_GUI_MiddlePart();

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Commands ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Commands : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "Commands". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_Commands( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_Commands(string new_text)
        {
            // .
            TextBox_Commands.Set_Text(new_text);

            // . 
            Generate_GUI_MiddlePart();

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Options ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Options : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "Options". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_Options( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_Options(string new_text)
        {
            // .
            TextBox_Options.Set_Text(new_text);

            // . 
            Generate_GUI_BottomPart();

            // Returns void. 
            return;
        }


        /////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Change_TextBox_Inventory ( string )        ///////////////    
        /// <summary>
        /// <c> Change_TextBox_Inventory : </c> <br/>  
        /// Takes in a string and Changes the Text in the Textbox "Inventory". <br/>  
        ///  <br/>  
        ///  <br/>  
        /// </summary>
        /// 
        /// <remarks>  
        /// Remember to call "Update_GUI" for the changes to be printed. <br/>  
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
        ///         Changes the Textbox Text, then Updates the Textbox and prints it out.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Update GUI </term>  
        ///         <description>  
        ///         Updates all Textbox Changes and prints it.  
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
        ///     // Changes the Textbox Text.
        ///     Change_TextBox_Inventory( "Hello World" );
        ///     
        ///     // Updates GUI.
        ///     Update_GUI;
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="new_text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public static void Change_TextBox_Inventory(string new_text)
        {
            // .
            TextBox_Inventory.Set_Text(new_text);

            // . 
            Generate_GUI_BottomPart();

            // Returns void. 
            return;
        }






    }


}


