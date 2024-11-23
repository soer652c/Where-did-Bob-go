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
using System.Diagnostics;
using System.Collections.Generic;

namespace Where_did_Bob_Go_VA.GUI_NS
{


    // TextBox
    // This class is used for generating and using textboxes in the user terminal.
    public class TextBox
    {

        ////////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Private Attributes          /////////////////////////   
        ////////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      

        //////////////////////////////////////////////////////////////////////////    
        ///////////////        textBox_default_spacing_Side        ///////////////   
        /// <summary>
        /// <c> textBox_default_spacing_Side : </c> <br/>  
        /// The number of empty Spaces on both Sides, as in the empty spaces " " on both sides of the 2 Side Lines. <br/>  
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
        ///         <term> Textbox Sides </term>  
        ///         <description>  
        ///         The lines marking the sides of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        protected uint textBox_default_spacing_Side;

        //////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        textBox_default_spacing_TopBottom_Inside        ///////////////   
        /// <summary>
        /// <c> textBox_default_spacing_TopBottom_Inside : </c> <br/>  
        /// The númber of empty lines inside the box, as in empty lines below the Top Line and above the Bottom Line. <br/>  
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
        ///         <term> Top/Bottom Line </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        protected uint textBox_default_spacing_TopBottom_Inside;

        ///////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        textBox_default_spacing_TopBottom_Outside        ///////////////   
        /// <summary>
        /// <c> textBox_default_spacing_TopBottom_Outside : </c> <br/>  
        /// The númber of empty lines outside the box, as in empty lines above the Top Line and below the Bottom Line. <br/>  
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
        ///         <term> Top/Bottom Line </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        protected uint textBox_default_spacing_TopBottom_Outside;

        /////////////////////////////////////////////////////////////////////////    
        ///////////////        textBox_Outline_Marker_Side        ///////////////   
        /// <summary>
        /// <c> textBox_Outline_Marker_Side : </c> <br/>  
        /// The character / string that is used to outline the Textbox Sides. <br/>  
        /// Fx '*', " * ", " 0 ", " || " or so on. <br/>  
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
        ///         <term> Textbox Sides </term>  
        ///         <description>  
        ///         The lines marking the sides of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        protected string textBox_Outline_Marker_Side;

        //////////////////////////////////////////////////////////////////////////////    
        ///////////////        textBox_Outline_Marker_TopBottom        ///////////////   
        /// <summary>
        /// <c> textBox_Outline_Marker_TopBottom : </c> <br/>  
        /// The character / string that is used to outline the Textbox Top/Bottom Line. <br/>  
        /// Fx '*', " * ", " 0 ", " || " or so on. <br/>  
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
        ///         <term> Top/Bottom Line </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        protected string textBox_Outline_Marker_TopBottom;

        /////////////////////////////////////////////////////////////    
        ///////////////        textBox_BoxType        ///////////////   
        /// <summary>
        /// <c> textBox_BoxType : </c> <br/>  
        /// Here we store the type of textbox / the name of the textbox. <br/>  
        /// Which will be printed inside the box at the top, if the "textBox_default_spacing_TopBottom" is set to at least 1. <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        protected string textBox_BoxType;

        ///////////////////////////////////////////////////////////////    
        ///////////////        textBox_TextLines        ///////////////   
        /// <summary>
        /// <c> textBox_TextLines : </c> <br/>  
        /// Here we store the lines of text to be used in the textbox. <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        protected string[] textBox_Text;







        ///////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Public Attributes          /////////////////////////   
        ///////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      

        ///////////////////////////////////////////////////////////    
        ///////////////        textBox_Width        ///////////////   
        /// <summary>
        /// <c> textBox_Width : </c> <br/>  
        /// The width of the Textbox, measured in number of characters the Textbox will take up. <br/>  
        /// Including the empty spaces to the left and right of the box.  <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        public uint textBox_Width;

        ////////////////////////////////////////////////////////////    
        ///////////////        textBox_Height        ///////////////   
        /// <summary>
        /// <c> textBox_Height : </c> <br/>  
        /// The height of the Textbox, measured in number of lines the Textbox will take up. <br/>  
        /// Including the empty lines above and below the box.  <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        public uint textBox_Height;

        ////////////////////////////////////////////////////////////    
        ///////////////        textBox_TextWidth        ////////////   
        /// <summary>
        /// <c> textBox_TextWidth : </c> <br/>  
        /// The width of the Textbox Text, measured in number of the characters that can fit on a signle line inside the textbox. <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        public uint textBox_TextWidth;

        ////////////////////////////////////////////////////////////    
        ///////////////        textBox_TextHeight        ///////////   
        /// <summary>
        /// <c> textBox_TextHeight : </c> <br/>  
        /// The height of the Textbox Text, measured in number of lines that can fit inside the box. <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        public uint textBox_TextHeight;







        //////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Constructors          /////////////////////////   
        //////////////////////////////////////////////////////////////////////////////////   
        //   
        //      

        //////////////////////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox ( uint, uint, string, uint, uint, string, uint )        ///////////////   
        /// <summary>
        /// <c> TextBox : </c> <br/>  
        /// Constructor for creating the object of the Class Textbox. <br/>  
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
        ///         <term> Top/Bottom </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="init_textBox_Width"> The number of characters that can fit inside the Textbox lines. </param>
        /// <param name="init_textBox_Height"> The number of lines that can fit inside the Textbox. </param>
        /// <param name="init_textBox_Outline_Marker_Side"> The character/characters used to mark both the sides and the Top/Bottom of the Textbox. </param>
        /// <param name="init_textBox_default_spacing_Side"> The number of empty spaces between the Side of the box. <br/> This both means the Text and the outside. </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Inside"> The number of empty lines between the Top/Bottom of the box and the Text inside the Textbox. </param>
        /// <param name="init_textBox_BoxType">  </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Outside"> The number of empty lines between the Top/Bottom of the box and the outside of the Textbox. </param>
        /// 
        ///
        public TextBox(uint init_textBox_Width = 20, uint init_textBox_Height = 1, string init_textBox_Outline_Marker_Side = "#", uint init_textBox_default_spacing_Side = 1, uint init_textBox_default_spacing_TopBottom_Inside = 0, string init_textBox_BoxType = "", uint init_textBox_default_spacing_TopBottom_Outside = 0)
        {
            // Here we set the starting values for the textbox.
            this.textBox_TextWidth = init_textBox_Width;
            this.textBox_TextHeight = init_textBox_Height;

            // Here we set the default spacing for the top, bottom and sides.   
            this.textBox_default_spacing_Side = init_textBox_default_spacing_Side;
            this.textBox_default_spacing_TopBottom_Inside = init_textBox_default_spacing_TopBottom_Inside;
            this.textBox_default_spacing_TopBottom_Outside = init_textBox_default_spacing_TopBottom_Outside;

            // Here we set the box-type/box-name that can be used.   
            this.textBox_BoxType = init_textBox_BoxType;

            // Here we set the Textbox Outline Marker, for both the sides and Top/Bottom.    
            this.textBox_Outline_Marker_Side = init_textBox_Outline_Marker_Side;
            this.textBox_Outline_Marker_TopBottom = init_textBox_Outline_Marker_Side;

            // Here we define the size of our string array.
            this.textBox_Text = new string[init_textBox_Height];
            this.textBox_Text[0] = "";

            // Here we calculate the total height and width of the text-box.   
            this.textBox_Height = this.textBox_TextHeight + (2 * this.textBox_default_spacing_TopBottom_Inside) + (2 * this.textBox_default_spacing_TopBottom_Outside) + (2); 
            this.textBox_Width = this.textBox_TextWidth + (4 * this.textBox_default_spacing_Side) + ((uint)this.textBox_Outline_Marker_Side.Length * 2); 

            // 
            return;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox ( uint, uint, string, string, uint, uint, string, uint )        ///////////////   
        /// <summary>
        /// <c> TextBox : </c> <br/>  
        /// Constructor for creating the object of the Class Textbox. <br/>  
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
        ///         <term> Top/Bottom </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="init_textBox_Width"> The number of characters that can fit inside the Textbox lines. </param>
        /// <param name="init_textBox_Height"> The number of lines that can fit inside the Textbox. </param>
        /// <param name="init_textBox_Outline_Marker_Side"> The character/characters used to mark the sides of the Textbox. </param>
        /// <param name="init_textBox_Outline_Marker_TopBottom"> The character/characters used to mark the Top/Bottom of the Textbox. </param>
        /// <param name="init_textBox_default_spacing_Side"> The number of empty spaces between the Side of the box. <br/> This both means the Text and the outside. </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Inside"> The number of empty lines between the Top/Bottom of the box and the Text inside the Textbox. </param>
        /// <param name="init_textBox_BoxType">  </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Outside"> The number of empty lines between the Top/Bottom of the box and the outside of the Textbox. </param>
        /// 
        /// 
        public TextBox(uint init_textBox_Width = 20, uint init_textBox_Height = 1, string init_textBox_Outline_Marker_Side = "#", string init_textBox_Outline_Marker_TopBottom = "#", uint init_textBox_default_spacing_Side = 1, uint init_textBox_default_spacing_TopBottom_Inside = 0, string init_textBox_BoxType = "", uint init_textBox_default_spacing_TopBottom_Outside = 0)
        {
            // Here we set the starting values for the textbox.
            this.textBox_TextWidth = init_textBox_Width;
            this.textBox_TextHeight = init_textBox_Height;

            // Here we set the default spacing for the top, bottom and sides.   
            this.textBox_default_spacing_Side = init_textBox_default_spacing_Side;
            this.textBox_default_spacing_TopBottom_Inside = init_textBox_default_spacing_TopBottom_Inside;
            this.textBox_default_spacing_TopBottom_Outside = init_textBox_default_spacing_TopBottom_Outside;

            // Here we set the box-type/box-name that can be used.   
            this.textBox_BoxType = init_textBox_BoxType;

            // Here we set the Textbox Outline Marker, for both the sides and Top/Bottom.    
            this.textBox_Outline_Marker_Side = init_textBox_Outline_Marker_Side;
            this.textBox_Outline_Marker_TopBottom = init_textBox_Outline_Marker_TopBottom;

            // Here we define the size of our string array.
            this.textBox_Text = new string[init_textBox_Height];
            this.textBox_Text[0] = "";

            // Here we calculate the total height and width of the text-box.   
            this.textBox_Height = this.textBox_TextHeight + (2 * this.textBox_default_spacing_TopBottom_Inside) + (2 * this.textBox_default_spacing_TopBottom_Outside) + (2);
            this.textBox_Width = this.textBox_TextWidth + (4 * this.textBox_default_spacing_Side) + ((uint)this.textBox_Outline_Marker_Side.Length * 2);

            // 
            return;
        }







        /////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Private Methods          /////////////////////////   
        /////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      

        ////////////////////////////////////////////////////////////////////////    
        ///////////////        Text_Seperation ( string )        ///////////////    
        /// <summary>
        /// <c> Text_Seperation : </c> <br/>  
        /// Takes in a string "text" as a parameter, "text" seperates its into an array of strings. <br/>  
        /// The methods looks for any "\n" in "text" and use it as a marker for splitting it into a array of string. <br/>  
        /// It then returns the array of strings. <br/>  
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
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        ///  String[ ]: Returns a string-array containing the Text. <br/>  
        /// </returns>
        /// 
        /// <param name="text"> The string that will be seperated into a string array. </param>
        /// 
        private string[] Text_Seperation(string text)        
        {
            // Takes the string and splits it into an array strings.
            // Each element is seperated by looking for the string "\n". 
            return text.Split("\n"); 
        }


        //////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_TopLine ( ref string[] , uint )        ///////////////    
        /// <summary>
        /// <c> Generate_TopLine : </c> <br/>  
        /// Generates the Top Line of the Textbox. <br/>  
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
        ///         <term> Top Line </term>  
        ///         <description>  
        ///         The line at the top of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Line Counter </term>  
        ///         <description>  
        ///         A counter the checks how many lines down we are in the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        ///  uint: Returns the Line Counter. <br/>  
        /// </returns>
        /// 
        /// <param name="TextBox_Array"> The array that will store the Top Line. </param>
        /// <param name="arraySpot"> The Line Counter that tell us at which array element, we start to put in the Top Line. </param>
        /// 
        private uint Generate_TopLine( ref string[] TextBox_Array, uint arraySpot )
        {
            //**************************************// 
            //          Top-Line Variables          // 
            //**************************************//  

            // textBox_ArraySpot_Counter    
            // We use this variable to keep track on how far down the string-array "TextBox_Array", we have gotten.
            // We will also return this variable at the end. 
            uint textBox_ArraySpot_Counter = arraySpot;

            // emptyLine_CharLength   
            // .   
            uint emptyLine_CharLength = this.textBox_TextWidth  +  (2 * this.textBox_default_spacing_Side);

            // topLine_CharLength   
            // .   
            uint topLine_CharLength = this.textBox_TextWidth  +  ( 2 * this.textBox_default_spacing_Side )  +  ( 2 * (uint)this.textBox_Outline_Marker_Side.Length );

            // topLine_BoxType_EmptySpace   
            // .   
            uint topLine_BoxType_EmptySpace = (uint)( (((double)emptyLine_CharLength - (double)textBox_BoxType.Length)) / 2.0D);




            //**************************************************// 
            //          The Empty Space Above Top-Line          // 
            //**************************************************//  

            // .   
            // Here we start to construct the empty part above the box.
            for ( ; textBox_ArraySpot_Counter < (arraySpot + this.textBox_default_spacing_TopBottom_Outside); textBox_ArraySpot_Counter++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = " ";
            }





            //********************************// 
            //          The Top-Line          // 
            //********************************//  

            //**************************************************************//
            //          The Empty Space to the Left of the TopLine          //    

            // Here we start to construct the textbox top-line, starting with the empty space. 
            for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
            }


            //**********************************// 
            //          The TopLine          //    

            // .    
            // .    
            if ( this.textBox_Outline_Marker_TopBottom.Length >= 1 )
            {
                // .     
                // Here we continue to construct the textbox top-line, making using the top-line.    
                for (uint outline_Marker_Count = 0; outline_Marker_Count < topLine_CharLength; )
                {
                    // .      
                    // .      
                    for (int outline_Marker_Char_Count = 0; outline_Marker_Char_Count < this.textBox_Outline_Marker_TopBottom.Length; outline_Marker_Char_Count++)
                    {
                        // .      
                        // Here we check if we have hit total length of the top-line, or if we still can add more.   
                        if (outline_Marker_Count < topLine_CharLength)
                        { 
                            // .     
                            // .     
                            TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + (this.textBox_Outline_Marker_TopBottom[outline_Marker_Char_Count]);

                            // Here we add any additional . 
                            outline_Marker_Count++;
                        }
                    }
                }
            }
            else
            {
                // .     
                // Here we continue to construct the textbox top-line, making using the top-line.   
                for (uint outline_Marker_Count = 0; outline_Marker_Count < topLine_CharLength; outline_Marker_Count++)
                {
                    // .     
                    // .     
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }
            }


            //***************************************************************//
            //          The Empty Space to the Right of the TopLine          //    

            // The Empty Space to the Right of the TopLine    
            // Here we start to construct the textbox top-line, starting with the empty space. 
            for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
            }




            // textBox_ArraySpot_Counter++   
            // .   
            textBox_ArraySpot_Counter++;




            //********************************************// 
            //          The Space Below Top-Line          // 
            //********************************************//  

            // .    
            for (uint topLine_Spacing_Below = textBox_ArraySpot_Counter + this.textBox_default_spacing_TopBottom_Inside; textBox_ArraySpot_Counter < topLine_Spacing_Below; textBox_ArraySpot_Counter++) 
            {
                //**************************************************************// 
                //          The Empty Space to the Left of the Textbox          //
                //          
                // Here we start to construct the textbox top-line, starting with the empty space. 
                for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }


                //*******************************************// 
                //          The Left Outline Marker          //    

                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + this.textBox_Outline_Marker_Side;


                //*****************************************************// 
                //          The Empty Space below the Topline          //   

                // .   
                for (uint emptyMiddle_Count = 0; emptyMiddle_Count < emptyLine_CharLength; emptyMiddle_Count++)
                {
                    // .    
                    // .    
                    if ( (textBox_ArraySpot_Counter <= (topLine_Spacing_Below - this.textBox_default_spacing_TopBottom_Inside)) && (emptyMiddle_Count >= topLine_BoxType_EmptySpace) && (emptyMiddle_Count < (topLine_BoxType_EmptySpace + this.textBox_BoxType.Length)) )
                    {
                        // .   
                        TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + this.textBox_BoxType[ (int)(emptyMiddle_Count - topLine_BoxType_EmptySpace) ];
                    }
                    else
                    {
                        // .   
                        TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                    }
                }


                //********************************************// 
                //          The Right Outline Marker          //    

                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + this.textBox_Outline_Marker_Side;


                //***************************************************************// 
                //          The Empty Space to the Right of the Textbox          //   

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


        ////////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_TextLines ( ref string[] , uint )        ///////////////    
        /// <summary>
        /// <c> Generate_TextLines : </c> <br/>  
        /// Generates the Text Lines of the Textbox. <br/>  
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
        ///         <term> Text Lines </term>  
        ///         <description>  
        ///         The lines in the middle of the Textbox, containing the Textbox Text.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Line Counter </term>  
        ///         <description>  
        ///         A counter the checks how many lines down we are in the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        ///  uint: Returns the Line Counter. <br/>  
        /// </returns>
        /// 
        /// <param name="TextBox_Array"> The array that will store the Text Lines. </param>
        /// <param name="arraySpot"> The Line Counter that tell us at which array element, we start to put in the Text Lines. </param>
        /// 
        private uint Generate_TextLines( ref string[] TextBox_Array, uint arraySpot )
        {
            //***************************************// 
            //          Text-Line Variables          // 
            //***************************************//  

            // textBox_ArraySpot_Counter    
            // We use this variable to keep track on how far down the string-array "TextBox_Array", we have gotten.
            // We will also return this variable at the end. 
            uint textBox_ArraySpot_Counter = arraySpot;

            //     
            // .   
            uint textBox_TextLines_Counter;




            //**********************************// 
            //          Text-Line Loop          // 
            //**********************************//  

            //      
            // .    
            for ( ; textBox_ArraySpot_Counter < (this.textBox_TextHeight + arraySpot); textBox_ArraySpot_Counter++)
            {
                //**************************************************************// 
                //          The Empty Space to the Left of the Textbox          //   

                // The Empty Space to the Left of the Middle    
                // Here we start to construct the textbox top-line, starting with the empty space. 
                for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }


                //*******************************************// 
                //          The Left Outline Marker          //    

                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker_Side;


                //*****************************************************************// 
                //          The Empty Space inside The TextBox, Left Side          // 

                // .   
                for (uint emptyMiddle_Count_Left = 0; emptyMiddle_Count_Left < this.textBox_default_spacing_Side; emptyMiddle_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }


                //************************************// 
                //          The Textbox Text          //

                // . 
                if (true)
                {
                    // .   
                    textBox_TextLines_Counter = textBox_ArraySpot_Counter - arraySpot;


                    // The Text Line    
                    // Here we add the text onto this line in the box.   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + this.textBox_Text[textBox_TextLines_Counter];
                }


                //******************************************************************// 
                //          The Empty Space inside The TextBox, Right Side          // 
 
                // .   
                for (uint emptyMiddle_Count_Right = 0; emptyMiddle_Count_Right < this.textBox_default_spacing_Side; emptyMiddle_Count_Right++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }


                //********************************************// 
                //          The Right Outline Marker          //    

                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker_Side;


                //***************************************************************// 
                //          The Empty Space to the Right of the Textbox          // 

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


        /////////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_BottomLine ( ref string[] , uint )        ///////////////    
        /// <summary>
        /// <c> Generate_BottomLine : </c> <br/>  
        /// Generates the Bottom Line of the Textbox. <br/>  
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
        ///         <term> Bottom Line </term>  
        ///         <description>  
        ///         The line at the bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Line Counter </term>  
        ///         <description>  
        ///         A counter the checks how many lines down we are in the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        ///  uint: Returns the Line Counter. <br/>  
        /// </returns>
        /// 
        /// <param name="TextBox_Array"> The array that will store the Bottom Line. </param>
        /// <param name="arraySpot"> The Line Counter that tell us at which array element, we start to put in the Bottom Line. </param>
        /// 
        private uint Generate_BottomLine( ref string[] TextBox_Array, uint arraySpot )
        {
            //*****************************************// 
            //          Bottom-Line Variables          // 
            //*****************************************//  

            // textBox_ArraySpot_Counter    
            // We use this variable to keep track on how far down the string-array "TextBox_Array", we have gotten.  
            // We will also return this variable at the end.  
            uint textBox_ArraySpot_Counter = arraySpot;

            // emptyLine_CharLength   
            // .   
            uint emptyLine_CharLength = this.textBox_TextWidth + (2 * this.textBox_default_spacing_Side);

            // bottomLine_CharLength   
            // .   
            uint bottomLine_CharLength = this.textBox_TextWidth + (2 * this.textBox_default_spacing_Side) + (2 * (uint)textBox_Outline_Marker_Side.Length);




            //*****************************************************// 
            //          The Empty Space Above Bottom-Line          // 
            //*****************************************************//  

            //      
            // .    
            for ( ; textBox_ArraySpot_Counter < (this.textBox_default_spacing_TopBottom_Inside + arraySpot); textBox_ArraySpot_Counter++)
            {
                //**************************************************************// 
                //          The Empty Space to the Left of the Textbox          //   

                // Here we start to construct the textbox bottom-line, starting with the empty space. 
                for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }


                //*******************************************// 
                //          The Left Outline Marker          //    
  
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker_Side;


                //*********************************************************// 
                //          The Empty Space above the Bottom Line          //      

                // .   
                for (uint emptyMiddle_Count = 0; emptyMiddle_Count < emptyLine_CharLength; emptyMiddle_Count++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }


                //********************************************// 
                //          The Right Outline Marker          //    
   
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + textBox_Outline_Marker_Side;


                //***************************************************************// 
                //          The Empty Space to the Right of the Textbox          //   

                // .   
                for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
                {
                    // .   
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }
            }




            //***********************************// 
            //          The Bottom-Line          // 
            //***********************************//  

            //*****************************************************************//
            //          The Empty Space to the Left of the BottomLine          //    

            // We add a number of empty space to the left of the Bottom Line, based on the number in "textBox_default_spacing_Side".  
            for (uint emptySpace_Count_Left = 0; emptySpace_Count_Left < this.textBox_default_spacing_Side; emptySpace_Count_Left++)
            {
                // .   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " "; 
            }

            //**********************************// 
            //          The BottomLine          //    

            // Checks to see if the length of the Bottom Line Marker is atleast 1 character long.    
            if (this.textBox_Outline_Marker_TopBottom.Length >= 1)
            {
                // Loops through the length of the Bottom Line, so we can add each character.    
                for (uint outline_Marker_Count = 0; outline_Marker_Count < bottomLine_CharLength;)
                {
                    // Loops through each character in the Bottom Line Marker "textBox_Outline_Marker_TopBottom".      
                    for (int outline_Marker_Char_Count = 0; outline_Marker_Char_Count < this.textBox_Outline_Marker_TopBottom.Length; outline_Marker_Char_Count++)
                    {
                        // Here we check if we have hit total length of the bottom-line, or if should add more characters.   
                        if (outline_Marker_Count < bottomLine_CharLength)
                        {
                            // Here we add (one character at a time) the Bottom Line Marker.     
                            TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + (this.textBox_Outline_Marker_TopBottom[outline_Marker_Char_Count]);

                            // Here we increment the counter with 1, to count the character added. 
                            outline_Marker_Count++;
                        }
                    }
                }
            }
            else
            {
                // Incase the Botttom Line Marker is set to nothing, we make use of Empty Space character instead.  
                for (uint outline_Marker_Count = 0; outline_Marker_Count < bottomLine_CharLength; outline_Marker_Count++)
                {
                    // Adds empty spaces instead of a line.     
                    TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " ";
                }
            }

            //******************************************************************//
            //          The Empty Space to the Right of the BottomLine          //    

            // Here we start to construct the textbox bottom-line, starting with the empty space.  
            for (uint emptySpace_Count_Right = 0; emptySpace_Count_Right < this.textBox_default_spacing_Side; emptySpace_Count_Right++)
            {
                // Adds empty space to the end of the line.   
                TextBox_Array[textBox_ArraySpot_Counter] = TextBox_Array[textBox_ArraySpot_Counter] + " "; 
            }




            //*****************************************************// 
            //          The Empty Space Below Bottom-Line          // 
            //*****************************************************//  

            // Here we construct the empty part below the box. 
            for ( ; textBox_ArraySpot_Counter < this.textBox_default_spacing_TopBottom_Outside; textBox_ArraySpot_Counter++) 
            {
                // Adds empty space to the line.   
                TextBox_Array[textBox_ArraySpot_Counter] = " "; 
            }

            // Returns the position in the string-array that is next. 
            return textBox_ArraySpot_Counter;
        }


        ///////////////////////////////////////////////////////////////////    
        ///////////////        Generate_TextBox (  )        ///////////////    
        /// <summary>
        /// <c> Generate_TextBox : </c> <br/>  
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
        ///         <term> Top/Bottom </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Text Line </term>  
        ///         <description>  
        ///         The lines in the middle of the Textbox that can contain the Textbox Text.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Generating the Top Line </term>  
        ///         <description>  
        ///         The process of producing and formatting, an string-array of the Top Line.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Generating the Text Lines </term>  
        ///         <description>  
        ///         The process of producing and formatting, an string-array of the Text Lines.  
        ///         </description>  
        ///     </item>  
        ///     
        ///     <item>  
        ///         <term> Generating the Bottom Line </term>  
        ///         <description>  
        ///         The process of producing and formatting, an string-array of the Bottom Line.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        /// </remarks>  
        /// 
        /// <returns> 
        /// String[ ]: Returns the combined/final string-array that contains the complete Textbox. <br/>  
        /// </returns>
        /// 
        private string[] Generate_TextBox()
        {

            // TextBox_StringArray    
            // We store the generated Textbox and returns it at the end.   
            string[] TextBox_StringArray = new string[(int)this.textBox_Height];


            // textBox_Line_Counter    
            // We use this variable to keep track on many lines have already been added to "TextBox_StringArray".
            uint textBox_Line_Counter = 0;


            // Generates the Top Line of the Textbox.  
            // The line count is returned and stored in "textBox_Line_Counter". 
            textBox_Line_Counter = Generate_TopLine(ref TextBox_StringArray, textBox_Line_Counter);


            // Generates the Text Lines of the Textbox.  
            // The line count is returned and stored in "textBox_Line_Counter". 
            textBox_Line_Counter = Generate_TextLines(ref TextBox_StringArray, textBox_Line_Counter);



            // Generates the Bottom Line of the Textbox.  
            // The line count is returned and stored in "textBox_Line_Counter". 
            textBox_Line_Counter = Generate_BottomLine(ref TextBox_StringArray, textBox_Line_Counter);


            // Returns the combined/final string-array that contains the complete Textbox. 
            return TextBox_StringArray;
        }








        ////////////////////////////////////////////////////////////////////////////////////   
        /////////////////////////          Public Methods          /////////////////////////   
        ////////////////////////////////////////////////////////////////////////////////////   
        //   
        //      

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_Settings ( uint, uint, string, uint, uint, string, uint )        ///////////////   
        /// <summary>
        /// <c> TextBox_Settings : </c> <br/>  
        /// Allows you to change the settings of the Textbox. <br/>  
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
        ///         <term> Top/Bottom </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox();
        ///     
        ///     textBox.TextBox_Settings(20, 4, "##", 1, 2, "Text Box 1", 0);
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="init_textBox_Width"> The number of characters that can fit inside the Textbox lines. </param>
        /// <param name="init_textBox_Height"> The number of lines that can fit inside the Textbox. </param>
        /// <param name="init_textBox_Outline_Marker_Side"> The character/characters used to mark both the sides and the Top/Bottom of the Textbox. </param>
        /// <param name="init_textBox_default_spacing_Side"> The number of empty spaces between the Side of the box. <br/> This both means the Text and the outside. </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Inside"> The number of empty lines between the Top/Bottom of the box and the Text inside the Textbox. </param>
        /// <param name="init_textBox_BoxType">  </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Outside"> The number of empty lines between the Top/Bottom of the box and the outside of the Textbox. </param>
        /// 
        public void TextBox_Settings(uint init_textBox_Width, uint init_textBox_Height, string init_textBox_Outline_Marker_Side, uint init_textBox_default_spacing_Side, uint init_textBox_default_spacing_TopBottom_Inside, string init_textBox_BoxType, uint init_textBox_default_spacing_TopBottom_Outside)
        {
            // Here we set the starting values for the textbox.
            this.textBox_TextWidth = init_textBox_Width;
            this.textBox_TextHeight = init_textBox_Height;

            // Here we set the default spacing for the top, bottom and sides.   
            this.textBox_default_spacing_Side = init_textBox_default_spacing_Side;
            this.textBox_default_spacing_TopBottom_Inside = init_textBox_default_spacing_TopBottom_Inside;
            this.textBox_default_spacing_TopBottom_Outside = init_textBox_default_spacing_TopBottom_Outside;

            // Here we set the box-type/box-name that can be used.   
            this.textBox_BoxType = init_textBox_BoxType;

            // Here we set the Textbox Outline Marker, for both the sides and Top/Bottom.    
            this.textBox_Outline_Marker_Side = init_textBox_Outline_Marker_Side;
            this.textBox_Outline_Marker_TopBottom = init_textBox_Outline_Marker_Side;

            // Here we define the size of our string array.
            this.textBox_Text = new string[init_textBox_Height];
            this.textBox_Text[0] = "";

            // Here we calculate the total height and width of the text-box.   
            this.textBox_Height = this.textBox_TextHeight + (2 * this.textBox_default_spacing_TopBottom_Inside) + (2 * this.textBox_default_spacing_TopBottom_Outside) + (2);
            this.textBox_Width = this.textBox_TextWidth + (4 * this.textBox_default_spacing_Side) + ((uint)this.textBox_Outline_Marker_Side.Length * 2);

            // Return void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////    
        ///////////////        TextBox_Settings ( uint, uint, string, string, uint, uint, string, uint )        ///////////////   
        /// <summary>
        /// <c> TextBox_Settings : </c> <br/>  
        /// Allows you to change the settings of the Textbox. <br/>  
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
        ///         <term> Top/Bottom </term>  
        ///         <description>  
        ///         The lines at the top and bottom of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox();
        ///     
        ///     textBox.TextBox_Settings(20, 4, "||", "##", 1, 2, "Text Box 1", 0);
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="init_textBox_Width"> The number of characters that can fit inside the Textbox lines. </param>
        /// <param name="init_textBox_Height"> The number of lines that can fit inside the Textbox. </param>
        /// <param name="init_textBox_Outline_Marker_Side"> The character/characters used to mark the sides of the Textbox. </param>
        /// <param name="init_textBox_Outline_Marker_TopBottom"> The character/characters used to mark the Top/Bottom of the Textbox. </param>
        /// <param name="init_textBox_default_spacing_Side"> The number of empty spaces between the Side of the box. <br/> This both means the Text and the outside. </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Inside"> The number of empty lines between the Top/Bottom of the box and the Text inside the Textbox. </param>
        /// <param name="init_textBox_BoxType">  </param>
        /// <param name="init_textBox_default_spacing_TopBottom_Outside"> The number of empty lines between the Top/Bottom of the box and the outside of the Textbox. </param>
        /// 
        public void TextBox_Settings(uint init_textBox_Width, uint init_textBox_Height, string init_textBox_Outline_Marker_Side, string init_textBox_Outline_Marker_TopBottom, uint init_textBox_default_spacing_Side, uint init_textBox_default_spacing_TopBottom_Inside, string init_textBox_BoxType, uint init_textBox_default_spacing_TopBottom_Outside)
        {
            // Here we set the starting values for the textbox.
            this.textBox_TextWidth = init_textBox_Width;
            this.textBox_TextHeight = init_textBox_Height;

            // Here we set the default spacing for the top, bottom and sides.   
            this.textBox_default_spacing_Side = init_textBox_default_spacing_Side;
            this.textBox_default_spacing_TopBottom_Inside = init_textBox_default_spacing_TopBottom_Inside;
            this.textBox_default_spacing_TopBottom_Outside = init_textBox_default_spacing_TopBottom_Outside;

            // Here we set the box-type/box-name that can be used.   
            this.textBox_BoxType = init_textBox_BoxType;

            // Here we set the Textbox Outline Marker, for both the sides and Top/Bottom.    
            this.textBox_Outline_Marker_Side = init_textBox_Outline_Marker_Side;
            this.textBox_Outline_Marker_TopBottom = init_textBox_Outline_Marker_TopBottom;

            // Here we define the size of our string array.
            this.textBox_Text = new string[init_textBox_Height];
            this.textBox_Text[0] = "";

            // Here we calculate the total height and width of the text-box.   
            this.textBox_Height = this.textBox_TextHeight + (2 * this.textBox_default_spacing_TopBottom_Inside) + (2 * this.textBox_default_spacing_TopBottom_Outside) + (2);
            this.textBox_Width = this.textBox_TextWidth + (4 * this.textBox_default_spacing_Side) + ((uint)this.textBox_Outline_Marker_Side.Length * 2);

            // Return void.  
            return;
        }


        ///////////////////////////////////////////////////////////////////    
        ///////////////        Set_Text ( string[] )        ///////////////    
        /// <summary>
        /// <c> Set_Text : </c> <br/>  
        /// Sets the Textbox Text to the content of the "text_array". <br/>  
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
        ///         <term> Sets the Textbox Text </term>  
        ///         <description>  
        ///         The process of changing and formatting, the content of the Textbox Text.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Set the Textbox Text to be the same as "text". 
        ///     textBox.SetText(text);
        ///     
        ///     // Here we print out the Textbox to the Console.  
        ///     Console.WriteLine( textBox.Generate_TextBox_ToStr() );
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="text_array"> The Text to be printed in the Textbox. <br/> Each element in the array is its own line, and "\n" are not allowed. </param>  
        /// 
        public void Set_Text(string[] text_array)
        {
            // Check to see if the number of lines given is more, then what can fit in the textbox.  
            if (text_array.Length <= this.textBox_TextHeight)
            {
                // text_array_LineCounter   
                // We use this to make sure that .    
                uint TextLines_LineCounter;


                //**********************************// 
                //          Add Text Lines          // 
                //**********************************//  

                // Add text_array to textBox_TextLines      
                // Loops through each string in the array to transfer them.  
                for (TextLines_LineCounter = 0; TextLines_LineCounter < text_array.Length; TextLines_LineCounter++)
                {
                    // Here we check if the element in "text_array" is empty.
                    if (!String.IsNullOrEmpty(text_array[TextLines_LineCounter]))
                    {
                        //******************************************// 
                        //          Add Text + Empty Space          //

                        // Check to see if the number of characters given is more, then what can fit on the line.  
                        if (text_array[TextLines_LineCounter].Length <= this.textBox_TextWidth)
                        {
                            // Adds the text from "text_array" to "textBox_Text".  
                            this.textBox_Text[TextLines_LineCounter] = text_array[TextLines_LineCounter];

                            // Loops through each remeaning spots that can fit on the line, based on the Text Width. 
                            for (int emptySpace_counter_AfterText = text_array[TextLines_LineCounter].Length; emptySpace_counter_AfterText < textBox_TextWidth; emptySpace_counter_AfterText++)
                            {
                                // Adds empty space to the line.
                                this.textBox_Text[TextLines_LineCounter] = this.textBox_Text[TextLines_LineCounter] + " ";
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
                        //***************************************************// 
                        //          Empty Element = All Empty Space          //

                        // We empty the string to make sure there is nothing left over from previous calls.      
                        this.textBox_Text[TextLines_LineCounter] = "";

                        // Loops through each character that can fit on the line, based on the Text Width.      
                        for (int emptySpace_counter_EmptyLine = 0; emptySpace_counter_EmptyLine < textBox_TextWidth; emptySpace_counter_EmptyLine++)
                        {
                            // Adds empty space to the line.
                            this.textBox_Text[TextLines_LineCounter] = this.textBox_Text[TextLines_LineCounter] + " ";
                        }
                    }
                }


                //************************************// 
                //          Fill Empty Lines          // 
                //************************************//  

                // Adds spaces to textBox_TextLines, after text_array if there is any lines left.    
                for (; TextLines_LineCounter < textBox_TextHeight; TextLines_LineCounter++)
                {
                    // We empty the string to make sure there is nothing left over from previous calls.      
                    this.textBox_Text[TextLines_LineCounter] = "";

                    // Loops through each character that can fit on the line, based on the Text Width. 
                    for (int emptySpace_counter_NoLine = 0; emptySpace_counter_NoLine < textBox_TextWidth; emptySpace_counter_NoLine++)
                    {
                        // Adds empty space to the line.
                        this.textBox_Text[TextLines_LineCounter] = this.textBox_Text[TextLines_LineCounter] + " ";
                    }

                }
            }
            else
            {
                // Throw Exception.  
                throw new Exception("The number of lines you want to print, is more then the number of lines in the textbox.");
            }

            // Returns void. 
            return;
        }


        /////////////////////////////////////////////////////////////////    
        ///////////////        Set_Text ( string )        ///////////////    
        /// <summary>
        /// <c> Set_Text : </c> <br/>  
        /// Sets the Textbox Text to the content of the "text". <br/>  
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
        ///         <term> Sets the Textbox Text </term>  
        ///         <description>  
        ///         The process of changing and formatting, the content of the Textbox Text.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string text = "Hello! \n" + "I am Alex. \n" + "What is your name?";
        ///     
        ///     // Set the Textbox Text to be the same as "text". 
        ///     textBox.SetText(text);
        ///     
        ///     // Here we print out the Textbox to the Console.  
        ///     Console.WriteLine( textBox.Generate_TextBox_ToStr() );
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns> 
        ///  <br/>  
        /// </returns>
        /// 
        /// <param name="text"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public void Set_Text(string text)
        {
            // Converts the string into a string array.   
            string[] text_array = Text_Seperation( text ); 

            // Sets the Textbox Text to the content of "text_array".   
            Set_Text(text_array);

            // Returns void. 
            return;
        }


        ////////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_TextBox_ToStrArr (  )        ///////////////    
        /// <summary>
        /// <c> Generate_TextBox_ToStrArr : </c> <br/>  
        /// Generates the Textbox in the format of a string array. <br/>  
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
        ///         <term> Generating the Textbox </term>  
        ///         <description>  
        ///         The process of producing and formatting, a string or an string-array of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Set the Textbox Text to be the same as "text". 
        ///     textBox.SetText(text);
        ///     
        ///     // Here we print out the Textbox to the Console.  
        ///     Console.WriteLine( textBox.Generate_TextBox_ToStr() );
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns>  
        ///  String[ ]: Returns a string array containing the full Textbox. <br/>
        ///  As each element in the array is a single line of the Textbox. <br/>  
        /// </returns>  
        ///  
        public string[] Generate_TextBox_ToStrArr()
        {
            // Returns the Textbox as an array of strings.  
            // This is done by using the method "Generate_TextBox()" to Generate the Textbox.   
            return this.Generate_TextBox();  
        }


        /////////////////////////////////////////////////////////////////////////    
        ///////////////        Generate_TextBox_ToStr (  )        ///////////////    
        /// <summary>
        /// <c> Generate_TextBox_ToStr : </c> <br/>  
        /// Generates the Textbox in the format of a string. <br/>  
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
        ///         <term> Generating the Textbox </term>  
        ///         <description>  
        ///         The process of producing and formatting, a string or an string-array of the Textbox.  
        ///         </description>  
        ///     </item>  
        ///     
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Set the Textbox Text to be the same as "text". 
        ///     textBox.SetText(text);
        ///     
        ///     // Here we print out the Textbox to the Console.  
        ///     Console.WriteLine( textBox.Generate_TextBox_ToStr() );
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns>  
        /// String: Returns a string containing the full Textbox. <br/>  
        /// </returns>  
        /// 
        public string Generate_TextBox_ToStr()
        {
            // Returns the Textbox as a string.  
            // This is done by using the method "Generate_TextBox()" to Generate the Textbox.   
            // Then using the "String.Join" method, which allow us to turn an array of strings into a single string.
            // We use "\n" to place in betweem each element in the string array.   
            return String.Join("\n", (this.Generate_TextBox()) );
        }


        ///////////////////////////////////////////////////////////////////////////    
        ///////////////        Output_TextBox_ToConsole (  )        ///////////////    
        /// <summary>
        /// <c> Output_TextBox_ToConsole : </c> <br/>  
        /// Prints out the textbox to the Console. <br/>  
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
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Set the Textbox Text to be the same as "text". 
        ///     textBox.SetText(text);
        ///     
        ///     // Outputs the Textbox to the terminal.
        ///     textBox.Output_TextBox_ToConsole();
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns>  
        ///  <br/>  
        /// </returns>  
        /// 
        public void Output_TextBox_ToConsole()
        {
            // Here we print out the Textbox to the Console, be calling the method "Generate_TextBox_ToStr()".   
            Console.WriteLine( Generate_TextBox_ToStr() );  

            // Returns void. 
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Output_TextBox_ToConsole ( string[] )        ///////////////    
        /// <summary>  
        /// <c> Output_TextBox_ToConsole : </c> <br/>  
        /// Prints out the textbox to the Console, using the "text_input" as the Textbox Text. <br/>  
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
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string[] text = {"Hello!", "I am Alex.", "What is your name?"};
        ///     
        ///     // Outputs the Textbox to the terminal.
        ///     textBox.Output_TextBox_ToConsole(text);
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns>  
        ///  <br/>  
        /// </returns>  
        /// 
        /// <param name="text_input"> The Text to be printed in the Textbox. <br/> Each element in the array is its own line, and "\n" are not allowed. </param>  
        /// 
        public void Output_TextBox_ToConsole(string[] text_input)
        {
            // Here we call the method "Set_Text( string[] )" to store the text.   
            this.Set_Text(text_input);

            // Here we print out the Textbox to the Console, be calling the method "Generate_TextBox_ToStr()".   
            Console.WriteLine( this.Generate_TextBox_ToStr() );  

            // Returns void.   
            return;
        }


        ///////////////////////////////////////////////////////////////////////////////////    
        ///////////////        Output_TextBox_ToConsole ( string )        ///////////////    
        /// <summary>  
        /// <c> Output_TextBox_ToConsole : </c> <br/>  
        /// Prints out the textbox to the Console, using the "text_input" as the Textbox Text. <br/>  
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
        ///  </list>  
        ///  
        ///  <example>
        ///     Here is an example of how to use this method: 
        ///     
        ///     <code>
        ///     
        ///     // Testbox Object. 
        ///     TextBox textBox = new TextBox(20, 4, "||", "##", 1, 2, "Text Box 1");
        ///     
        ///     // Text to put inside the Textbox. 
        ///     string text = "Hello! \n" + "I am Alex. \n" + "What is your name?";
        ///     
        ///     // Outputs the Textbox to the terminal. 
        ///     textBox.Output_TextBox_ToConsole(text); 
        ///     
        ///     </code>
        ///  </example>
        /// </remarks>  
        /// 
        /// <returns>  
        ///  <br/>  
        /// </returns>  
        /// 
        /// <param name="text_input"> The Text to be printed in the Textbox. <br/> To signal a new-line/line-break use "\n". </param>  
        /// 
        public void Output_TextBox_ToConsole(string text_input)
        {
            // Here we call the method "Set_Text( string )" to store the text.   
            this.Set_Text(text_input);

            // Here we print out the Textbox to the Console, be calling the method "Generate_TextBox_ToStr()".   
            Console.WriteLine( this.Generate_TextBox_ToStr() );

            // Returns void.   
            return;
        }





    }
}


