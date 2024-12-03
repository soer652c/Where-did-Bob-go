using System;
using System.Diagnostics;

using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.GUI_NS;
using Where_did_Bob_Go_VA.Item_NS;
using Where_did_Bob_Go_VA.NPC_NS;
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;
using Where_did_Bob_Go_VA.Player_NS;
using Where_did_Bob_Go_VA.Proc_Gen_NS;
using Where_did_Bob_Go_VA.World_NS;

using static Where_did_Bob_Go_VA.GUI_NS.GUI;


namespace Where_did_Bob_Go_VA
{

    public class Main_Class
    {


        public Main_Class() { }

        static public string FirstLetter_Upper(string start_string)
        {
            if (start_string == null)
            {
                return null;
            }

            if (start_string.Length > 1)
            {
                return char.ToUpper(start_string[0]) + start_string.Substring(1);
            }

            return start_string.ToUpper();
        }


        static public void NPC_Names_Generator(ref NPC_DialogID[] npc_DialogID_Arr)
        {
            npc_DialogID_Arr[0].NPC_Name = "Alex";
            npc_DialogID_Arr[1].NPC_Name = "Mia";
            npc_DialogID_Arr[2].NPC_Name = "Liam";
            npc_DialogID_Arr[3].NPC_Name = "Clara";
            npc_DialogID_Arr[4].NPC_Name = "Jack";
            npc_DialogID_Arr[5].NPC_Name = "Emma";
            npc_DialogID_Arr[6].NPC_Name = "Steen";
            npc_DialogID_Arr[7].NPC_Name = "Thomas";
            npc_DialogID_Arr[8].NPC_Name = "Sarah";
            npc_DialogID_Arr[9].NPC_Name = "Ben";
            npc_DialogID_Arr[10].NPC_Name = "Lily";
            npc_DialogID_Arr[11].NPC_Name = "James";
            return;
        }

        static public void NPC_Locations_Generator(ref NPC_DialogID[] npc_DialogID_Arr)
        {
            npc_DialogID_Arr[0].NPC_Location = "bar";
            npc_DialogID_Arr[1].NPC_Location = "subway";
            npc_DialogID_Arr[2].NPC_Location = "school";
            npc_DialogID_Arr[3].NPC_Location = "school";
            npc_DialogID_Arr[4].NPC_Location = "subway";
            npc_DialogID_Arr[5].NPC_Location = "hospital";
            npc_DialogID_Arr[6].NPC_Location = "psychiatry";
            npc_DialogID_Arr[7].NPC_Location = "psychiatry";
            npc_DialogID_Arr[8].NPC_Location = "community";
            npc_DialogID_Arr[9].NPC_Location = "park";
            npc_DialogID_Arr[10].NPC_Location = "playground";
            npc_DialogID_Arr[11].NPC_Location = "playground";
            return;
        }

        static public void NPC_ID_Generator(ref NPC_DialogID[] npc_DialogID_Arr)
        {
            Random rnd = new Random();

            int temp_value1_Of100 = 0, temp_value2_Of100 = 0, temp_value3_Of3 = 0;

            for (int j = 0; j < npc_DialogID_Arr.Length; j++)
            {
                temp_value1_Of100 = rnd.Next(14, 100);
                temp_value2_Of100 = rnd.Next(27, 100);

                temp_value1_Of100 = temp_value2_Of100 - temp_value1_Of100;

                temp_value2_Of100 = rnd.Next(48, 100);

                temp_value3_Of3 = temp_value2_Of100 % 4;

                if ((temp_value3_Of3 != 0) && (temp_value3_Of3 < 0))
                {
                    npc_DialogID_Arr[j].NPC_ID = (temp_value3_Of3).ToString();
                    //Console.WriteLine((temp_value3_Of3).ToString());
                }
                else
                {
                    npc_DialogID_Arr[j].NPC_ID = (rnd.Next(1, 4)).ToString();
                    //Console.WriteLine((rnd.Next(1, 4)).ToString());
                }

                //Console.WriteLine(npc_DialogID_Arr[j].NPC_ID);
            }

            return;
        }

        static public void File_Location_Generator(ref NPC_DialogID[] npc_DialogID_Arr)
        {
            string current_file_location = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string file_location = "\\Dialogtree";

            for (int j = 0; j < npc_DialogID_Arr.Length; j++)
            {
                npc_DialogID_Arr[j].File_Location = current_file_location + file_location;
            }
            return;
        }

        static public void File_ID_Generator(ref NPC_DialogID[] npc_DialogID_Arr)
        {
            for (int j = 0; j < npc_DialogID_Arr.Length; j++)
            {
                npc_DialogID_Arr[j].File_ID = npc_DialogID_Arr[j].NPC_ID;
            }
            return;
        }

        static public void File_Name_Generator(ref NPC_DialogID[] npc_DialogID_Arr)
        {
            for (int j = 0; j < npc_DialogID_Arr.Length; j++)
            {
                npc_DialogID_Arr[j].File_Name = FirstLetter_Upper(npc_DialogID_Arr[j].NPC_Location) + "_" + FirstLetter_Upper(npc_DialogID_Arr[j].NPC_Name) + "_" + FirstLetter_Upper(npc_DialogID_Arr[j].NPC_ID) + ".txt";
            }
            return;
        }


        //private NPC_DialogID[] npc_DialogID_Arr;
        static public NPC_DialogID[] RandomGame_Generator(NPC_DialogID[] npc_DialogID_Arr)
        {
            NPC_Names_Generator(ref npc_DialogID_Arr);

            NPC_Locations_Generator(ref npc_DialogID_Arr);

            NPC_ID_Generator(ref npc_DialogID_Arr);

            File_Location_Generator(ref npc_DialogID_Arr);

            File_ID_Generator(ref npc_DialogID_Arr);

            File_Name_Generator(ref npc_DialogID_Arr);

            return npc_DialogID_Arr;
        }



        // static void Main(string[] arg)
        // Jetbrain just straight up use the commands "dotnet build" and "dotnet run".
        // In the dotnet frame-work the compiler looks for any class methods called "public static void Main",
        // and uses is the Main, to control the order of sekvenses run. 
        public static void Main()
        {
            NPC_DialogID[] npc_DialogID_Arr;

            npc_DialogID_Arr = new NPC_DialogID[15];

            npc_DialogID_Arr = RandomGame_Generator(npc_DialogID_Arr);

            // . 
            Game game = new Game(npc_DialogID_Arr);

        }

    }


}