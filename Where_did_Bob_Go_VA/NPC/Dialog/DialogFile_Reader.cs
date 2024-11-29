using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;
using System.Text;

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

namespace Where_did_Bob_Go_VA.NPC_NS.Dialog_NS
{

    // DialogFile_Reader
    // This class is used for finding and reading files.
    public class DialogFile_Reader
    {
        // .  
        private string file_location;

        // .  
        private string file_name;

        // .  
        private string file_path;

        // .  
        private string file_type;

        // .  
        private string data_StartMarker;

        // .  
        private string data_StopMarker;

        // .  
        private FileStream file_stream;




        // .   
        public List<string> file_Data = new List<string>(11);





        public DialogFile_Reader(string init_file_loation, string init_file_name)
        {
            // .   
            this.file_location = init_file_loation;
            this.file_name = init_file_name;
            this.file_path = file_location + "\\" + file_name;
        }


        public DialogFile_Reader(string init_file_loation, string init_file_name, string init_data_StartMarker, string init_data_StopMarker) 
        {
            // .   
            this.file_location = init_file_loation;
            this.file_name = init_file_name;
            this.file_path = file_location + "\\" + file_name;

            // .   
            this.data_StartMarker = init_data_StartMarker;
            this.data_StopMarker = init_data_StopMarker;
        }




        private void OpenFile_ReadMode()
        {
            // .   
            if ( File.Exists(file_path) )
            {
                // .   
                this.file_stream = System.IO.File.OpenRead(this.file_path);
            }
            else
            {
                // Incase the file doesn't exist we throw an exception, that already exist in the IO-library.    
                throw new FileNotFoundException("Unable to find the specified file.\n" + "File Path: " + file_path);
            }
        }





        // .  
        public void LoadData_fromFile(string init_data_StartMarker, string init_data_StopMarker)
        {
            // .   
            this.data_StartMarker = init_data_StartMarker;
            this.data_StopMarker = init_data_StopMarker;

            // .  
            file_Data.Clear();

            // .   
            OpenFile_ReadMode();

            // Here we call StreamReader, so we .   
            StreamReader file_reader = new StreamReader(this.file_stream);


            // Here we create a temporary string that can contain the data we store.   
            string start_string;

            // . 
            string stop_string;

            // There is 2 ways to check if the file is at end, by using 2 different conditions. 
            //    
            // file_reader.Peek()   
            // "file_reader.Peek()" return the ASCII value (Int32) of the next character in the file. 
            // If there is no more characters to be read, it returns -1 .   
            //     
            // (line = file_reader.ReadLine()) != null  
            // "(line = file_reader.ReadLine()) != null" reads in the next line and checks if the string it receives is equal to null.    
            // This way we can check if we have reached the end of the file.  
            //   
            while (file_reader.Peek() >= 0)
            {
                // Here we read the in the whole line as a string and store it in "line".    
                // If we use "(line = file_reader.ReadLine()) != null" as a condition for the While-loop, this line of code is not needed.     
                start_string = file_reader.ReadLine();

                // .   
                if (start_string.Contains(data_StartMarker))
                {
                    // .   
                    while (true)
                    {
                        // .   
                        stop_string = file_reader.ReadLine();


                        // .  
                        if (stop_string.Contains(data_StopMarker))
                        {
                            // Just to be reduntant, we closes the connection to the file in read-mode.
                            // Since it will be closed when leaving this method.
                            file_reader.Close();

                            // Returns void. 
                            return;
                        }
                        else
                        {
                            // .  
                            file_Data.Add(stop_string);
                        }
                    }
                }
            }

            // Just to be reduntant, we closes the connection to the file in read-mode.
            // Since it will be closed when leaving this method.
            file_reader.Close();

            // Returns void. 
            return;
        }






    }
}
