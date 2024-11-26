using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Where_did_Bob_Go_VA.NPC_NS.Dialog_NS
{

    public struct NPC_Dialog_Struct
    {
        public string[] Location;

        public string[] Name;

        public string[] ID;

        public string[] Risk;




        public NPC_Dialog_Options D00;





        public NPC_Dialog_Options D00_01;

        public NPC_Dialog_Options D00_02;

        public NPC_Dialog_Options D00_03;






        public NPC_Dialog_Options D00_01_01;

        public NPC_Dialog_Options D00_01_02;



        public NPC_Dialog_Options D00_02_01;

        public NPC_Dialog_Options D00_02_02;



        public NPC_Dialog_Options D00_03_01;

        public NPC_Dialog_Options D00_03_02;





    }

    public struct NPC_Dialog_Options
    {
        public string[] text;

        public string[] Options_1;

        public string[] Options_2;

        public string[] Options_3;

        public string[] Options_4;
    }


}
