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
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;

namespace Where_did_Bob_Go_VA.NPC_NS.Dialog_NS
{

    // Dialog_Formatter
    // This class is used for formatting the dialog and informations, when reading the dialog files.
    public class Dialog_Formatter : DialogFile_Reader
    {
        // . 
        private string Location = "Location>";
        private string Name = "Name>";
        private string ID = "ID>";
        private string Risk = "Risk>";


        // .   
        private string Dialog_Text_Marker = ".Text>";
        private string Dialog_Option_1 = ".OP01>";
        private string Dialog_Option_2 = ".OP02>";
        private string Dialog_Option_3 = ".OP03>";



        // .   
        private string Dialog_00_Start = "<D00";
        private string Dialog_00_Stop = "</D00";

        private string Dialog_00_01_Start = "<D00.01";
        private string Dialog_00_01_Stop = "</D00.01";

        private string Dialog_00_02_Start = "<D00.02";
        private string Dialog_00_02_Stop = "</D00.02";

        private string Dialog_00_03_Start = "<D00.03";
        private string Dialog_00_03_Stop = "</D00.03";




        private string Dialog_00_01_01_Start = "<D00.01.01";
        private string Dialog_00_01_01_Stop = "</D00.01.01";

        private string Dialog_00_01_02_Start = "<D00.01.02";
        private string Dialog_00_01_02_Stop = "</D00.01.02";



        private string Dialog_00_02_01_Start = "<D00.02.01";
        private string Dialog_00_02_01_Stop = "</D00.02.01";

        private string Dialog_00_02_02_Start = "<D00.02.02";
        private string Dialog_00_02_02_Stop = "</D00.02.02";



        private string Dialog_00_03_01_Start = "<D00.03.01";
        private string Dialog_00_03_01_Stop = "</D00.03.01";

        private string Dialog_00_03_02_Start = "<D00.03.02";
        private string Dialog_00_03_02_Stop = "</D00.03.02";





        public NPC_Dialog_Struct NPC_DialogTree;



        public Dialog_Formatter (string init_file_location, string init_file_name) : base (init_file_location, init_file_name)
        {
            // .   
            Extract_DialogTree_from_File();
        }





        // .   
        private string[] Extract_Data(string init_data_StartMarker, string init_data_StopMarker)
        {
            // .   
            LoadData_fromFile(init_data_StartMarker, init_data_StopMarker);

            // .    
            string[] data = new string[file_Data.Count];

            // .   
            for (int i = 0; i < file_Data.Count; i++)
            {
                // .   
                data[i] = file_Data.ElementAt(i);
            }

            // .   
            return data;
        }





        // .    
        private NPC_Dialog_Options3 Extract_Dialog_Options3(string init_data_StartMarker, string init_data_StopMarker)
        {
            // .   
            NPC_Dialog_Options3 npc_Dialog_Options3_Data = new NPC_Dialog_Options3();

            // . 
            npc_Dialog_Options3_Data.text = Extract_Data((init_data_StartMarker + Dialog_Text_Marker), (init_data_StopMarker + Dialog_Text_Marker));

            // . 
            npc_Dialog_Options3_Data.Options_1 = Extract_Data((init_data_StartMarker + Dialog_Option_1), (init_data_StopMarker + Dialog_Option_1));

            // . 
            npc_Dialog_Options3_Data.Options_2 = Extract_Data((init_data_StartMarker + Dialog_Option_2), (init_data_StopMarker + Dialog_Option_2));

            // . 
            npc_Dialog_Options3_Data.Options_3 = Extract_Data((init_data_StartMarker + Dialog_Option_3), (init_data_StopMarker + Dialog_Option_3));

            // .   
            return npc_Dialog_Options3_Data;
        }


        private NPC_Dialog_Options2 Extract_Dialog_Options2(string init_data_StartMarker, string init_data_StopMarker)
        {
            // .   
            NPC_Dialog_Options2 npc_Dialog_Options2_Data = new NPC_Dialog_Options2();

            // . 
            npc_Dialog_Options2_Data.text = Extract_Data((init_data_StartMarker + Dialog_Text_Marker), (init_data_StopMarker + Dialog_Text_Marker));

            // . 
            npc_Dialog_Options2_Data.Options_1 = Extract_Data((init_data_StartMarker + Dialog_Option_1), (init_data_StopMarker + Dialog_Option_1));

            // . 
            npc_Dialog_Options2_Data.Options_2 = Extract_Data((init_data_StartMarker + Dialog_Option_2), (init_data_StopMarker + Dialog_Option_2));

            // .   
            return npc_Dialog_Options2_Data;
        }

        private NPC_Dialog_Options0 Extract_Dialog_Options0(string init_data_StartMarker, string init_data_StopMarker)
        {
            // .   
            NPC_Dialog_Options0 npc_Dialog_Options0_Data = new NPC_Dialog_Options0();

            // . 
            npc_Dialog_Options0_Data.text = Extract_Data((init_data_StartMarker + Dialog_Text_Marker), (init_data_StopMarker + Dialog_Text_Marker));

            // .   
            return npc_Dialog_Options0_Data;
        }





        // .    
        public void Extract_DialogTree_from_File ()
        {
            // .   
            NPC_DialogTree.Location = Extract_Data(("<" + Location), ("</" + Location));

            NPC_DialogTree.Name = Extract_Data(("<" + Name), ("</" + Name));
            
            NPC_DialogTree.ID = Extract_Data(("<" + ID), ("</" + ID));

            NPC_DialogTree.Risk = Extract_Data(("<" + Risk), ("</" + Risk));



            // .   
            NPC_DialogTree.D00 = Extract_Dialog_Options3(Dialog_00_Start, Dialog_00_Stop);



            // .   
            NPC_DialogTree.D00_01 = Extract_Dialog_Options2(Dialog_00_01_Start, Dialog_00_01_Stop);
            NPC_DialogTree.D00_02 = Extract_Dialog_Options2(Dialog_00_02_Start, Dialog_00_02_Stop);
            NPC_DialogTree.D00_03 = Extract_Dialog_Options2(Dialog_00_03_Start, Dialog_00_03_Stop);



            // .   
            NPC_DialogTree.D00_01_01 = Extract_Dialog_Options0(Dialog_00_01_01_Start, Dialog_00_01_01_Stop);
            NPC_DialogTree.D00_01_02 = Extract_Dialog_Options0(Dialog_00_01_02_Start, Dialog_00_01_02_Stop);

            // .   
            NPC_DialogTree.D00_02_01 = Extract_Dialog_Options0(Dialog_00_02_01_Start, Dialog_00_02_01_Stop);
            NPC_DialogTree.D00_02_02 = Extract_Dialog_Options0(Dialog_00_02_02_Start, Dialog_00_02_02_Stop);

            // .   
            NPC_DialogTree.D00_03_01 = Extract_Dialog_Options0(Dialog_00_03_01_Start, Dialog_00_03_01_Stop);
            NPC_DialogTree.D00_03_02 = Extract_Dialog_Options0(Dialog_00_03_02_Start, Dialog_00_03_02_Stop);


            // .   
            return;
        }





    }
}
