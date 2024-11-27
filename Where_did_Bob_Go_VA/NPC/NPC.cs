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

namespace Where_did_Bob_Go_VA.NPC_NS
{

    public class NPC
    {
        public string Place;
        //public Dialog_Tree;
        public bool NPCvisibility;
        public bool NPCwarningsigns;
        public string NPCname;
        public uint NPCage;
        public char NPCgender;
        public string[] NPCidentifiers;
        public string NPCID;
        public string CurrentNPC;
        public string NPCriskLevel;
        public bool StartStop;

        private NPC_Dialog_Struct npc_Dialog_Structt;
        private Dictionary<string, NPC_Dialog_Options> DialogOptionsTree;
        

        // .  
        private string file_location = "\\DialogFolder";
        private string file_name;


        public NPC(string name, string init_file_loation, string init_file_name)
        {
            // .
            NPCname = name;
        }


        public void Extract_DialogTree(string init_file_loation, string init_file_name)
        {
            // .   
            npc_Dialog_Structt = Get_NPC_DialogTree(init_file_loation, init_file_name);

            // . 
            DialogOptionsTree.Add("D00", npc_Dialog_Structt.D00);
            DialogOptionsTree.Add("D00.01", npc_Dialog_Structt.D00_01);
            DialogOptionsTree.Add("D00.02", npc_Dialog_Structt.D00_02);
            DialogOptionsTree.Add("D00.03", npc_Dialog_Structt.D00_03);

            DialogOptionsTree.Add("D00.01.01", npc_Dialog_Structt.D00_01_01);
            DialogOptionsTree.Add("D00.01.02", npc_Dialog_Structt.D00_01_02);

            DialogOptionsTree.Add("D00.02.01", npc_Dialog_Structt.D00_02_01);
            DialogOptionsTree.Add("D00.02.02", npc_Dialog_Structt.D00_02_02);

            DialogOptionsTree.Add("D00.03.01", npc_Dialog_Structt.D00_03_01);
            DialogOptionsTree.Add("D00.03.02", npc_Dialog_Structt.D00_03_02);

        }



        //public bool SuicideRisk(bool warningSigns)
        //{
        //    // Reads the imput from console
        //    Console.ReadLine();
        //    if (warningSigns)
        //    {
        //        Console.WriteLine("This person does have warning signs and should seek help.");
        //        return true;
        //        // Return true if there are warning signs
        //    }
        //    else
        //    {
        //        Console.WriteLine("This person does not show any warning signs.");
        //        return false;
        //        // Return false if there are no warning signs
        //    }
        //}

        public void StartConversation()
        {
           StartStop = true;
            NPC_Dialog_Options initial_conversation = DialogOptionsTree["D00"];
            string next_conversation = "D00";
            while (StartStop == true && NPCvisibility == true)
            {
                if (next_conversation == "D00")
                {
                    // While loop kalder en metoden Converstaion
                    next_conversation = next_conversation + Conversation_Options3(initial_conversation);
                }
                else if ((next_conversation == "D00.01") || (next_conversation == "DOO.02") || (next_conversation == "D00.03"))
                {
                    next_conversation = next_conversation + Conversation_Options2(DialogOptionsTree[next_conversation]);
                }
                else if ((next_conversation == "D00.01.01") || (next_conversation == "DOO.01.02") || (next_conversation == "D00.02.01") || (next_conversation == "D00.02.02") || (next_conversation == "DOO.03.01") || (next_conversation == "D00.03.02"))
                {
                    next_conversation = next_conversation + Conversation_Options0(DialogOptionsTree[next_conversation]);

                }
                  // Nested if, som har en valgmulighed i nr. 4. som modificere at vi kan gå tilbage i dialogtræet

            }

            // Boolean StartConversaion (true)
            // While loop, der tjekker om NPCvisibulity og er StartConversion sat til true
            // While loop kalder en metoden Converstaion
            // når stop conversation flipper til false. så skal startConveration lukke while loop

        }

            // metode string Conversation (NPC_Dialog_Options)
            private string Conversation_Options3(NPC_Dialog_Options dialog1)
            {
                Change_TextBox_Main(dialog1.text);

                string[] temper = new string[dialog1.Options_1.Length + dialog1.Options_2.Length + dialog1.Options_3.Length + 1];

                int k = 0;
                for (int i = 0; i < dialog1.Options_1.Length; i++)
                {
                            temper[k] = dialog1.Options_1[i];
                    k++;
                }

                for (int i = 0; i < dialog1.Options_2.Length; i++)
                    {
                    temper[k] = dialog1.Options_2[i];
                    k++;
                }

                for (int i = 0; i < dialog1.Options_3.Length; i++)
                {
                    temper[k] = dialog1.Options_3[i];
                    k++;
                }

                temper[k] = "Retrun to previous";

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
                    //Go back
                    break;

                    default:
                        Console.WriteLine("There no options here containg this")
                            // Handle invalid input
                        break;
                }
            }

                                // hvis du vælger 1, skal den hente teksten fra 1 i dialogtræret. Ved hjælp af Chase/break;
                                // returner tilbage til StartConversation. Der giver nye parameter, der gør det muligt at navigere i dialogtræet

                                //metode string Conversation (NPC_Dialog_OPtions2)

                                //metode string Conversation (NPC_Dialog_Options0)
       public void StopConversation()
       {
                    // If statemat flipper boolean StartConversiation(false)
       }
                    

                    //public void UseMonocle(Moncle monocle)
                    //{

                    //}

        private void NPC_identifiers(string NPCName, int NPCage, string NPCgender)
        {

        }

        public bool GuessInput()
        {
            Console.WriteLine("Does the NPC show warning signs? (yes/no)");
            string guess = Console.ReadLine();
            return guess?.ToLower() == "yes";
        }

        /*public bool GuessCheck(bool guess)
        {
            if (guess == Warningsigns)
            {
                Console.WriteLine("Gæt er korrekt.");
                return true;
            }
            else
            {
                Console.WriteLine("Gæt er forkert.");
                return false;
            }
        }*/


        private bool NPC_visibility(bool visibility)
        // changes depending if the NPC is visible
        {
            // if condition is visible NPC is visible
            // else NPC is hidden
            return visibility;
        }


       
          
        }

    }

}

