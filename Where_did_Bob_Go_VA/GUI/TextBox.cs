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

namespace Where_did_Bob_Go_VA.GUI_NS
{


    // TextBox
    // This class is used for generating and using textboxes in the user terminal.
    public class TextBox
    {

        //////////////////   Private Attributes   //////////////////  
        // .   


        /////   default_spacing   /////  
        // The height of the textbox, measured in number of lines that can fit inside the box. 
        protected uint textBox_default_spacing_Side;

        /////   default_spacing   /////  
        // The height of the textbox, measured in number of lines that can fit inside the box. 
        protected uint textBox_default_spacing_TopBottom;

        /////   textBox_Outline_Marker   /////  
        // The character / string that used to outline the box. Fx '*', " * ", " 0 ", " || " or so on. 
        protected string textBox_Outline_Marker;

        /////   textBox_TextLines   /////   
        // Here we store the lines of text to be used in the textbox.  
        protected string[] textBox_TextLines;





        //////////////////   Public Attributes   //////////////////  
        // .   


        /////   textBox_Width   /////  
        // The width of the textbox, measured in number of the characters that can fit on a signle line inside the textbox. 
        public uint textBox_Width;

        /////   textBox_Height   /////  
        // The height of the textbox, measured in number of lines that can fit inside the box. 
        public uint textBox_Height;

        /////   textBox_TextWidth   /////  
        // The width of the textbox, measured in number of the characters that can fit on a signle line inside the textbox. 
        public uint textBox_TextWidth;

        /////   textBox_TextHeight   /////  
        // The height of the textbox, measured in number of lines that can fit inside the box. 
        public uint textBox_TextHeight;





        //////////////////   Constructors   //////////////////  
        // .   


        /////   Constructor   /////   
        // .   
        public TextBox(uint init_textBox_Width = 20, uint init_textBox_Height = 1, string init_textBox_Outline_Marker = "#", uint init_textBox_default_spacing_Side = 1, uint init_textBox_default_spacing_TopBottom = 0)
        {
            // Here we set the starting values for the textbox.
            this.textBox_TextWidth = init_textBox_Width;
            this.textBox_TextHeight = init_textBox_Height;
            this.textBox_default_spacing_Side = init_textBox_default_spacing_Side;
            this.textBox_default_spacing_TopBottom = init_textBox_default_spacing_TopBottom;
            this.textBox_Outline_Marker = init_textBox_Outline_Marker;

            // Here we define the size of our string array.
            this.textBox_TextLines = new string[init_textBox_Height];
            this.textBox_TextLines[0] = "";

            // Here we calculate the total height and width of the text-box.   
            this.textBox_Height = this.textBox_TextHeight + (4 * this.textBox_default_spacing_TopBottom) + (2); 
            this.textBox_Width = this.textBox_TextWidth + (4 * this.textBox_default_spacing_Side) + ((uint)this.textBox_Outline_Marker.Length * 2); 

            // 
            return;
        }







        //////////////////   Private Methods   //////////////////  
        // .   


        /////   Generate_TopLine ( ref string[] , uint )   /////   
        // Here we print out the textbox to the Console.  
        private uint Generate_TopLine( ref string[] TextBox_Array, uint arraySpot )
        {
            // textBox_ArraySpot_Counter    
            // We use this variable to keep track on how far down the string-array "TextBox_Array", we have gotten.
            // We will also return this variable at the end. 
            uint textBox_ArraySpot_Counter = arraySpot;

            // emptyLine_CharLength   
            // .   
            uint emptyLine_CharLength = this.textBox_TextWidth + (2 * this.textBox_default_spacing_Side);

            // topLine_CharLength   
            // .   
            uint topLine_CharLength = this.textBox_TextWidth + ( 2 * this.textBox_default_spacing_Side ) + ( 2 * (uint)textBox_Outline_Marker.Length );




            // The Empty Space Above Top-Line    
            // .   
            // Here we start to construct the empty part above the box.
            for ( ; textBox_ArraySpot_Counter < this.textBox_default_spacing_TopBottom; textBox_ArraySpot_Counter++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = " ";
            }




            // The Top-Line    
            // Here we start to construct the Top-Line.   

            // The Empty Space to the Left of the TopLine    
            // Here we start to construct the textbox top-line, starting with the empty space. 
            for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
            }

            // The TopLine     
            // Here we continue to construct the textbox top-line, making using the top-line. 
            for (uint outline_Marker_Count = 0; outline_Marker_Count < topLine_CharLength; outline_Marker_Count++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;
            }

            // The Empty Space to the Right of the TopLine    
            // Here we start to construct the textbox top-line, starting with the empty space. 
            for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
            }




            // The Space Below Top-Line   
            // Here we start to construct the space below the Top-Line.  

            // textBox_ArraySpot_Counter++   
            // .   
            textBox_ArraySpot_Counter++;

            //      
            // .    
            for (uint topLine_Spacing_Below = textBox_ArraySpot_Counter + this.textBox_default_spacing_TopBottom; textBox_ArraySpot_Counter < topLine_Spacing_Below; textBox_ArraySpot_Counter++) 
            {
                // The Empty Space to the Left of the Middle    
                // Here we start to construct the textbox top-line, starting with the empty space. 
                for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                // The Left Outline Marker    
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;

                // The Empty Middle   
                // .   
                for (uint emptyMiddle_Count = 0; emptyMiddle_Count < emptyLine_CharLength; emptyMiddle_Count++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                // The Right Outline Marker    
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;

                // The Empty Space to the Right of the Middle   
                // .   
                for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }
            }


            // Returns the position in the string-array that is next. 
            return textBox_ArraySpot_Counter;
        }


        /////   Generate_TextLines ( ref string[] , uint )   /////     
        // Here we print out the textbox to the Console.  
        private uint Generate_TextLines( ref string[] TextBox_Array, uint arraySpot )
        {
            // textBox_ArraySpot_Counter    
            // We use this variable to keep track on how far down the string-array "TextBox_Array", we have gotten.
            // We will also return this variable at the end. 
            uint textBox_ArraySpot_Counter = arraySpot;

            //     
            // .   
            uint textBox_TextLines_Counter;


            //      
            // .    
            for ( ; textBox_ArraySpot_Counter < (this.textBox_TextHeight + arraySpot); textBox_ArraySpot_Counter++)
            {
                // The Empty Space to the Left of the Middle    
                // Here we start to construct the textbox top-line, starting with the empty space. 
                for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                // The Left Outline Marker    
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;

                // The Empty Middle Left   
                // .   
                for (uint emptyMiddle_Count_Left = 0; emptyMiddle_Count_Left < this.textBox_default_spacing_Side; emptyMiddle_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                if (true)
                {
                    // .   
                    textBox_TextLines_Counter = textBox_ArraySpot_Counter - arraySpot;


                    // The Text Line    
                    // Here we add the text onto this line in the box.   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + this.textBox_TextLines[textBox_TextLines_Counter];
                }

                // The Empty Middle Right   
                // .   
                for (uint emptyMiddle_Count_Right = 0; emptyMiddle_Count_Right < this.textBox_default_spacing_Side; emptyMiddle_Count_Right++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                // The Right Outline Marker    
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;

                // The Empty Space to the Right of the Middle   
                // .   
                for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

            }

            // return. 
            return textBox_ArraySpot_Counter;
        }


        /////   Generate_BottomLine ( ref string[] , uint )   /////     
        // Here we print out the textbox to the Console.  
        private uint Generate_BottomLine( ref string[] TextBox_Array, uint arraySpot )
        {
            // textBox_ArraySpot_Counter    
            // We use this variable to keep track on how far down the string-array "TextBox_Array", we have gotten.  
            // We will also return this variable at the end.  
            uint textBox_ArraySpot_Counter = arraySpot;

            // emptyLine_CharLength   
            // .   
            uint emptyLine_CharLength = this.textBox_TextWidth + (2 * this.textBox_default_spacing_Side);

            // bottomLine_CharLength   
            // .   
            uint bottomLine_CharLength = this.textBox_TextWidth + (2 * this.textBox_default_spacing_Side) + (2 * (uint)textBox_Outline_Marker.Length);




            // The Space Above Bottom-Line   
            // Here we start to construct the space above the Bottom-Line.  

            //      
            // .    
            for ( ; textBox_ArraySpot_Counter < (this.textBox_default_spacing_TopBottom + arraySpot); textBox_ArraySpot_Counter++)
            {
                // The Empty Space to the Left of the Middle    
                // Here we start to construct the textbox bottom-line, starting with the empty space. 
                for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                // The Left Outline Marker    
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;

                // The Empty Middle   
                // .   
                for (uint emptyMiddle_Count = 0; emptyMiddle_Count < emptyLine_CharLength; emptyMiddle_Count++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }

                // The Right Outline Marker    
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker;

                // The Empty Space to the Right of the Middle   
                // .   
                for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }
            }




            // The Bottom-Line    
            // Here we start to construct the Bottom-Line.   

            // .


            // The Empty Space to the Left of the BottomLine    
            // Here we start to construct the textbox bottom-line, starting with the empty space.  
            for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " "; 
            }

            // The BottomLine     
            // Here we continue to construct the textbox bottom-line, making using the bottom-line.  
            for (uint outline_Marker_Count = 0; outline_Marker_Count < bottomLine_CharLength; outline_Marker_Count++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker; 
            }

            // The Empty Space to the Right of the BottomLine    
            // Here we start to construct the textbox bottom-line, starting with the empty space.  
            for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " "; 
            }




            // The Empty Space Below Bottom-Line    
            // .   
            // Here we construct the empty part below the box. 
            for ( ; textBox_ArraySpot_Counter < this.textBox_default_spacing_TopBottom; textBox_ArraySpot_Counter++) 
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = " "; 
            }



            // Returns the position in the string-array that is next. 
            return textBox_ArraySpot_Counter;

        }







        //////////////////   Private Methods   //////////////////  
        // .   


        /////   TextBox_Settings (  )   /////   
        // Here we generate the box and .  
        public void TextBox_Settings(uint init_textBox_Width, uint init_textBox_Height, string init_textBox_Outline_Marker)
        {
            // Here we set the starting values for the textbox.
            this.textBox_TextWidth = init_textBox_Width;
            this.textBox_TextHeight = init_textBox_Height;
            this.textBox_Outline_Marker = init_textBox_Outline_Marker; 

            // Here we define the size of our string array.
            this.textBox_TextLines = new string[init_textBox_Height];
            this.textBox_TextLines[0] = "";

            // Here we calculate the total height and width of the text-box.   
            this.textBox_Height = this.textBox_TextHeight + (4 * this.textBox_default_spacing_TopBottom) + (2);
            this.textBox_Width = this.textBox_TextWidth + (4 * this.textBox_default_spacing_Side) + ((uint)this.textBox_Outline_Marker.Length * 2);

            // 
            return;
        }


        /////   Set_Text ( string[] )   /////   
        // Here we add the text-lines to the text-box.  
        public void Set_Text(string[] text_array)
        {
            //try
            //{
            // Check to see if the number of lines given is more, then what can fit in the textbox.  
            if (text_array.Length <= this.textBox_TextHeight)
            {
                // text_array_LineCounter   
                // We use this to make sure that .    
                uint TextLines_LineCounter;



                // Add text_array to textBox_TextLines      
                // Loops through each string in the array to transfer them.  
                for (TextLines_LineCounter = 0; TextLines_LineCounter < text_array.Length; TextLines_LineCounter++)
                {
                    // Here we check if the string is empty.
                    if (!String.IsNullOrEmpty(text_array[TextLines_LineCounter]))
                    {
                        // Check to see if the number of characters given is more, then what can fit on the line.  
                        if (text_array[TextLines_LineCounter].Length <= this.textBox_TextWidth)
                        {
                            // .  
                            this.textBox_TextLines[TextLines_LineCounter] = text_array[TextLines_LineCounter];

                            // . 
                            for (int emptySpace_counter_AfterText = text_array[TextLines_LineCounter].Length; emptySpace_counter_AfterText < textBox_TextWidth; emptySpace_counter_AfterText++)
                            {
                                // .
                                this.textBox_TextLines[TextLines_LineCounter] = this.textBox_TextLines[TextLines_LineCounter] + " ";
                            }
                        }
                        else
                        {
                            // Throw Exception.  
                            throw new Exception("The length of your string is longer then the space on the line.");
                        }
                    }
                    else if (String.IsNullOrEmpty(text_array[TextLines_LineCounter]))
                    {
                        // We empty the string to make sure there is nothing left over from previous calls.      
                        this.textBox_TextLines[TextLines_LineCounter] = "";

                        // .      
                        for (int emptySpace_counter_EmptyLine = 0; emptySpace_counter_EmptyLine < textBox_TextWidth; emptySpace_counter_EmptyLine++)
                        {
                            // .
                            this.textBox_TextLines[TextLines_LineCounter] = this.textBox_TextLines[TextLines_LineCounter] + " ";
                        }
                    }
                }

                // Adds spaces to textBox_TextLines, after text_array    
                // .    
                for (; TextLines_LineCounter < textBox_TextHeight; TextLines_LineCounter++)
                {
                    // We empty the string to make sure there is nothing left over from previous calls.      
                    this.textBox_TextLines[TextLines_LineCounter] = "";

                    // . 
                    // . 
                    for (int emptySpace_counter_NoLine = 0; emptySpace_counter_NoLine < textBox_TextWidth; emptySpace_counter_NoLine++)
                    {
                        // .
                        this.textBox_TextLines[TextLines_LineCounter] = this.textBox_TextLines[TextLines_LineCounter] + " ";
                    }

                }
            }
            else
            {
                // Throw Exception.  
                throw new Exception("The number of lines you want to print, more then the number of lines in the textbox.");
            }
            //}
            //catch (Exception e)
            //{
            //    // Log Exception. 
            //}

            // Return nothing when done. 
            return;
        }


        /////   Generate_TextBox (  )   /////     
        // Here we print out the textbox to the Console.  
        public string[] Generate_TextBox_ToStrArr()
        {
            



            // TextBox_StringArray    
            // .   
            string[] TextBox_StringArray = new string[(int)this.textBox_Height];

            // textBox_Line_Counter    
            // We use this variable to keep track on many lines have already been added to "TextBox_StringArray".
            uint textBox_Line_Counter = 0;


            //try
            //{
                // .  
                textBox_Line_Counter = Generate_TopLine(ref TextBox_StringArray, textBox_Line_Counter);
                //Console.WriteLine(textBox_Line_Counter);

                

                // .  
                textBox_Line_Counter = Generate_TextLines(ref TextBox_StringArray, textBox_Line_Counter);
                //Console.WriteLine(textBox_Line_Counter);

                

                // .  
                textBox_Line_Counter = Generate_BottomLine(ref TextBox_StringArray, textBox_Line_Counter);
                //Console.WriteLine(textBox_Line_Counter);

                

            //}
            //catch (Exception e)
            //{
            //    // Log Exception. 
            //    Console.WriteLine(e);

            //    // Re-Throw
            //    throw new Exception(e.Message); 
            //}

            // return. 
            return TextBox_StringArray;  
        }


        /////   Generate_TextBox (  )   /////     
        // Here we print out the textbox to the Console.  
        public string Generate_TextBox_ToStr()
        {
            //    
            // .   
            string TextBox_String = "";

            // .
            TextBox_String = String.Join( "\n", ( this.Generate_TextBox_ToStrArr() ) );

            // return. 
            return TextBox_String;
        }


        /////   Output_TextBox_Console (  )   /////     
        // Here we print out the textbox to the Console.  
        public void Output_TextBox_ToConsole()
        {
            //try
            //{
                // .   
                Console.WriteLine( Generate_TextBox_ToStr() );  
            //}
            //catch (Exception e)
            //{
            //    // Log Exception. 
            //}

            // return. 
            return;
        }


        /////   Output_TextBox_Console ( string[] )   /////     
        // Here we print out the textbox to the Console.  
        public void Output_TextBox_ToConsole(string[] text_input)
        {
            //try
            //{
                // .   
                Set_Text(text_input);  

                // .   
                Console.WriteLine( Generate_TextBox_ToStr() );  

            //}
            //catch (Exception e)
            //{
            //    // Log Exception. 
            //}

            // return. 
            return;
        }



        

    }
}


