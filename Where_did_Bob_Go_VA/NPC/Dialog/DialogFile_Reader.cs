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
using System.Xml.Linq;

namespace Where_did_Bob_Go_VA.NPC_NS.Dialog_NS
{

    // DialogFile_Reader
    // This class is used for finding and reading files.
    public class DialogFile_Reader
    {
         if (File.Exists(dialogFilePath))
            {
            var allLines = File.ReadAllLines(dialogFilePath);
        bool sectionFound = false;
        var dialogList = new List<string>();

                // Find the section with the given keyword
                foreach (var line in allLines)
                {
                    if (line.Trim() == sectionKeyword)
                    {
                        sectionFound = true;
                        continue;
                    }

                    // Collect lines after the section starts
                    if (sectionFound && !string.IsNullOrWhiteSpace(line))
                    {
                        dialogList.Add(line);
                    }
                    else if (sectionFound && string.IsNullOrWhiteSpace(line))
{
    break; // End of section
}
                            }

                            DialogLines = dialogList.ToArray();
                        }
                        else
{
    Console.WriteLine($"Error: Dialog file '{dialogFilePath}' not found for NPC {name}.");
    DialogLines = new string[] { "..." };
}

currentLineIndex = 0;
                    }

    }
}
