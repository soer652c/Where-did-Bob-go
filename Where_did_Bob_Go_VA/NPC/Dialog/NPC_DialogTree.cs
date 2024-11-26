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

    // Dialog_NPC
    // This class is for getting the dialog options from the dialog files and store the informations, based on ID and such.
    public static class NPC_DialogTree
    {

        private static Dialog_Formatter dialog_formatter;


        private static string file_location;

        private static string file_name;

        private static string file_path;


        public static NPC_Dialog_Struct Get_NPC_DialogTree(string init_file_loation, string init_file_name)
        {
            // .   
            file_location = init_file_loation;
            file_name = init_file_name;
            file_path = file_location + "\\" + file_name;

            // . 
            dialog_formatter = new Dialog_Formatter(file_location, file_name);

            // .   
            dialog_formatter.Extract_DialogTree_from_File();

            // .   
            return dialog_formatter.NPC_DialogTree;
        }
    }
}
