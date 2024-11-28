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

using static Where_did_Bob_Go_VA.GUI_NS.GUI;
using static Where_did_Bob_Go_VA.NPC_NS.Dialog_NS.NPC_DialogTree;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.ComponentModel.Design;

namespace Where_did_Bob_Go_VA.NPC_NS
{

    public class NPC
    {
        private NPC_Dialog_Struct npc_Dialog_Struct;
        private Dictionary<string, NPC_Dialog_Options> DialogOptionsTree;


        private NPC_DialogID npc_DialogID;


        public string Place;
        public bool NPCvisibility = true;
        public string NPC_Name;
        public string NPC_ID;
        public string NPC_Location;
        public string NPC_RiskLevel;
        public bool StartStop_Talk;



        public NPC(NPC_DialogID init_npc_DialogID, string init_name)
        {
            // .
            this.NPC_Name = init_name;
            this.npc_DialogID = init_npc_DialogID;
        }


        public void Extract_DialogTree()
        {
            // .   
            npc_Dialog_Struct = Get_NPC_DialogTree(npc_DialogID.File_Location, npc_DialogID.File_Name);

            // . 
            DialogOptionsTree.Add("D00", npc_Dialog_Struct.D00);
            DialogOptionsTree.Add("D00.01", npc_Dialog_Struct.D00_01);
            DialogOptionsTree.Add("D00.02", npc_Dialog_Struct.D00_02);
            DialogOptionsTree.Add("D00.03", npc_Dialog_Struct.D00_03);

            DialogOptionsTree.Add("D00.01.01", npc_Dialog_Struct.D00_01_01);
            DialogOptionsTree.Add("D00.01.02", npc_Dialog_Struct.D00_01_02);

            DialogOptionsTree.Add("D00.02.01", npc_Dialog_Struct.D00_02_01);
            DialogOptionsTree.Add("D00.02.02", npc_Dialog_Struct.D00_02_02);

            DialogOptionsTree.Add("D00.03.01", npc_Dialog_Struct.D00_03_01);
            DialogOptionsTree.Add("D00.03.02", npc_Dialog_Struct.D00_03_02);

        }


        public void Extract_DialogTree(string init_file_loation, string init_file_name)
        {
            // .   
            npc_Dialog_Struct = Get_NPC_DialogTree(init_file_loation, init_file_name);

            // . 
            DialogOptionsTree.Add("D00", npc_Dialog_Struct.D00);
            DialogOptionsTree.Add("D00.01", npc_Dialog_Struct.D00_01);
            DialogOptionsTree.Add("D00.02", npc_Dialog_Struct.D00_02);
            DialogOptionsTree.Add("D00.03", npc_Dialog_Struct.D00_03);

            DialogOptionsTree.Add("D00.01.01", npc_Dialog_Struct.D00_01_01);
            DialogOptionsTree.Add("D00.01.02", npc_Dialog_Struct.D00_01_02);

            DialogOptionsTree.Add("D00.02.01", npc_Dialog_Struct.D00_02_01);
            DialogOptionsTree.Add("D00.02.02", npc_Dialog_Struct.D00_02_02);

            DialogOptionsTree.Add("D00.03.01", npc_Dialog_Struct.D00_03_01);
            DialogOptionsTree.Add("D00.03.02", npc_Dialog_Struct.D00_03_02);

        }



        public void StartConversation(Context context)
        {
            StartStop_Talk = true;
            NPC_Dialog_Options initial_conversation = DialogOptionsTree["D00"];
            string next_conversation = "D00";
            string ConversationOpstionreturn = "";
            string[] GoBack ;
            while (StartStop_Talk == true && NPCvisibility == true)
            {
                if (next_conversation == "D00")
                {
                    // While loop kalder en metoden Converstaion
                    next_conversation = next_conversation + Conversation_Options3(initial_conversation);
                }
                else if ((next_conversation == "D00.01") || (next_conversation == "DOO.02") || (next_conversation == "D00.03"))
                {
                    ConversationOpstionreturn = Conversation_Options2(DialogOptionsTree[next_conversation]);
                    // inde i elseIf statamteten skal det som converstion2 returner gemmes i "Stringen" tjekke at det der returneres skal lægges til eller trækkes fra
                    if ( ConversationOpstionreturn == "back")
                    {
                        GoBack = next_conversation.Split(".");
                        next_conversation = "";
                        int i = 0;
                        for (; i < (GoBack.Length - 1); i++) 
                        {
                            if (i == 0)
                            {
                                next_conversation = GoBack[0];
                            }
                            else
                            {
                                next_conversation = next_conversation + "." + GoBack[i];
                            }
                        }
                    }
                    else 
                    {
                        next_conversation = next_conversation + Conversation_Options2(DialogOptionsTree[next_conversation]);
                    }
                    
                }
                else if ((next_conversation == "D00.01.01") || (next_conversation == "DOO.01.02") || (next_conversation == "D00.02.01") || (next_conversation == "D00.02.02") || (next_conversation == "DOO.03.01") || (next_conversation == "D00.03.02"))
                {
                    ConversationOpstionreturn = Conversation_Options0(DialogOptionsTree[next_conversation]);
                    // inde i elseIf statamteten skal det som converstion2 returner gemmes i "Stringen" tjekke at det der returneres skal lægges til eller trækkes fra
                    if (ConversationOpstionreturn == "back")
                    {
                        GoBack = next_conversation.Split(".");
                        next_conversation = "";
                        int i = 0;
                        for (; i < (GoBack.Length - 1); i++)
                        {
                            if (i == 0)
                            {
                                next_conversation = GoBack[0];
                            }
                            else
                            {
                                next_conversation = next_conversation + "." + GoBack[i];
                            }
                        }
                    }
                    else
                    {
                        next_conversation = next_conversation + Conversation_Options0(DialogOptionsTree[next_conversation]);
                    }
                }
            }

            Console.ReadLine();

            (context.GetCurrent()).DisplayRoom();
        }



        private string Conversation_Options0(NPC_Dialog_Options dialog_Input)
        {
            Change_TextBox_Main(dialog_Input.text);
            string[] backbox = { "Go back to previous conversation" };
            string[] leavebox = { "Leave conversation" };
            string[] temper = new string[backbox.Length + leavebox.Length + 2];

            temper[0] = "Type \"4\" or \"5\" to pick options:";
            temper[1] = "";

            int k = 2;

            backbox[0] = "4. " + backbox[0];
            for (int i = 0; i < backbox.Length; i++)
            {
                temper[k] = backbox[i];

                k++;

            }

            leavebox[0] = "5. " + leavebox[0];
            for (int i = 0; i < leavebox.Length; i++)
            {
                temper[k] = leavebox[i];

                k++;

            }

            Change_TextBox_Options(temper);
            Update_GUI();

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "4":
                    return "back";
                    //Go back
                    break;
                case "5":
                    Game.registry.Dispatch("leave");
                    break;

                default:
                    Console.WriteLine("There no options here containing " + answer);
                    // Handle invalid input
                    break;
            }
            return "";
        }





        // Boolean StartConversaion (true)
        // While loop, der tjekker om NPCvisibulity og er StartConversion sat til true
        // While loop kalder en metoden Converstaion
        // når stop conversation flipper til false. så skal startConveration lukke while loop
        private string Conversation_Options2(NPC_Dialog_Options dialog_Input)
        {
            Change_TextBox_Main(dialog_Input.text);
            string[] backbox = { "Go back to previous conversation" };
            string[] leavebox = { "Leave conversation" };
            string[] temper = new string[dialog_Input.Options_1.Length + dialog_Input.Options_2.Length + backbox.Length + leavebox.Length + 2];

            temper[0] = "Type \"1\", \"2\", \"4\" or \"5\" to pick options: ";
            temper[1] = "";

            int k = 2;
            dialog_Input.Options_1[0] = "1. " + dialog_Input.Options_1[0];
            for (int i = 0; i < dialog_Input.Options_1.Length; i++)
            {
                temper[k] = dialog_Input.Options_1[i];
                k++;
            }

            dialog_Input.Options_2[0] = "2. " + dialog_Input.Options_2[0];
            for (int i = 0; i < dialog_Input.Options_2.Length; i++)
            {
                temper[k] = dialog_Input.Options_2[i];
                k++;
            }

            backbox[0] = "4. " + backbox[0];
            for (int i = 0; i < backbox.Length; i++)
            {
                temper[k] = backbox[i];

                k++;

            }

            leavebox[0] = "5. " + leavebox[0];
            for (int i = 0; i < leavebox.Length; i++)
            {
                temper[k] = leavebox[i];

                k++;

            }

            Change_TextBox_Options(temper);
            Update_GUI();

            string answer = Console.ReadLine();

            switch (answer)
            {
                case "1":
                    // Handle option 1
                    return ".01";
                    break;

                case "2":
                    // Handle option 2
                    return ".02";
                    break;

                case "4":
                    return "back";
                    //Go back
                    break;
                case "5":
                    Game.registry.Dispatch("leave");
                    break;

                default:
                    Console.WriteLine("There no options here containing " + answer);
                    // Handle invalid input
                    break;
            }
            return "";
        }





        // metode string Conversation (NPC_Dialog_Options)
        private string Conversation_Options3(NPC_Dialog_Options dialog_Input)
        {
            Change_TextBox_Main(dialog_Input.text);
            string[] backbox = { "Go back to previous conversation" };
            string[] leavebox = { "Leave conversation" };
            string[] temper = new string[dialog_Input.Options_1.Length + dialog_Input.Options_2.Length + dialog_Input.Options_3.Length + backbox.Length + leavebox.Length + 2];


            temper[0] = "Type \"1\", \"2\", \"3\", \"4\" or \"5\" to pick options: ";
            temper[1] = "";

            int k = 2;
            dialog_Input.Options_1[0] = "1. " + dialog_Input.Options_1[0];
            for (int i = 0; i < dialog_Input.Options_1.Length; i++)
            {
                temper[k] = dialog_Input.Options_1[i];
                k++;
            }

            dialog_Input.Options_2[0] = "2. " + dialog_Input.Options_2[0];
            for (int i = 0; i < dialog_Input.Options_2.Length; i++)
            {
                temper[k] = dialog_Input.Options_2[i];
                k++;
            }

            dialog_Input.Options_3[0] = "3. " + dialog_Input.Options_3[0];
            for (int i = 0; i < dialog_Input.Options_3.Length; i++)
            {
                temper[k] = dialog_Input.Options_3[i];
                k++;
            }

            backbox[0] = "4. " + backbox[0];
            for (int i = 0; i < backbox.Length; i++)
            {
                temper[k] = backbox[i];

                k++;

            }

            leavebox[0] = "5. " + leavebox[0];
            for (int i = 0; i < leavebox.Length; i++)
            {
                temper[k] = leavebox[i];

                k++;

            }

            Change_TextBox_Options(temper);
            Update_GUI();

            string answer= Console.ReadLine();

            switch (answer)
            {
                case "1":
                    // Handle option 1
                    return ".01";
                    break;

                case "2":
                    // Handle option 2
                    return ".02";
                    break;

                case "3":
                    // Handle option 3
                    return ".03";
                break;

                case "4":
                    return "back";
                //Go back
                break;

                case "5":
                    Game.registry.Dispatch("leave");
                    break;

            default:
                Console.WriteLine("There no options here containing " + answer);
                        // Handle invalid input
                    break;
            }
            return "";
        }

                                
        // hvis du vælger 1, skal den hente teksten fra 1 i dialogtræret. Ved hjælp af Chase/break;
        // returner tilbage til StartConversation. Der giver nye parameter, der gør det muligt at navigere i dialogtræet

        //metode string Conversation (NPC_Dialog_OPtions2)

        //metode string Conversation (NPC_Dialog_Options0)
        public void StopConversation()
        {
            StartStop_Talk = false;
        }
        
        public bool NPC_visibility(bool visibility)
        // changes depending if the NPC is visible
        {
            // if condition is visible NPC is visible
            // else NPC is hidden
            return visibility;
        }
         
    }
}

