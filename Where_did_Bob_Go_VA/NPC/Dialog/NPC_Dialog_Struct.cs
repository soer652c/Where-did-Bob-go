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




        public NPC_Dialog_Options3 D00;





        public NPC_Dialog_Options2 D00_01;

        public NPC_Dialog_Options2 D00_02;

        public NPC_Dialog_Options2 D00_03;






        public NPC_Dialog_Options1 D00_01_01;

        public NPC_Dialog_Options1 D00_01_02;



        public NPC_Dialog_Options1 D00_02_01;

        public NPC_Dialog_Options1 D00_02_02;



        public NPC_Dialog_Options1 D00_03_01;

        public NPC_Dialog_Options1 D00_03_02;






        public NPC_Dialog_Options0 D00_01_01_01;

        public NPC_Dialog_Options0 D00_01_02_01;



        public NPC_Dialog_Options0 D00_02_01_01;

        public NPC_Dialog_Options0 D00_02_02_01;



        public NPC_Dialog_Options0 D00_03_01_01;

        public NPC_Dialog_Options0 D00_03_02_01;


    }

    public struct NPC_Dialog_Options3
    {
        public string[] text;

        public string[] Options_1;

        public string[] Options_2;

        public string[] Options_3;
    }


    public struct NPC_Dialog_Options2
    {
        public string[] text;

        public string[] Options_1;

        public string[] Options_2;
    }


    public struct NPC_Dialog_Options1
    {
        public string[] text;

        public string[] Options_1;
    }


    public struct NPC_Dialog_Options0
    {
        public string[] text;
    }


}
