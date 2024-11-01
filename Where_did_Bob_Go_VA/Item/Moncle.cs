﻿using System;
using System.Diagnostics;

using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.GUI_NS;
using Where_did_Bob_Go_VA.Item_NS;
using Where_did_Bob_Go_VA.NPC_NS;
using Where_did_Bob_Go_VA.NPC_NS.Dialog_NS;
using Where_did_Bob_Go_VA.Player_NS;
using Where_did_Bob_Go_VA.Proc_Gen_NS;
using Where_did_Bob_Go_VA.World_NS;
using Where_did_Bob_Go_VA.Game_NS;


namespace Where_did_Bob_Go_VA.Item
{
    public class Moncle
    {
        public string Help { get; }
        public string Message { get; }

        public Moncle(string help, string message)
        {
            Help = help;
            Message = message;
        }

        public void Speak()
        {
            Console.WriteLine("You need help?");
        }

    }
}
