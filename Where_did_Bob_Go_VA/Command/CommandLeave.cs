﻿using System;
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
using Microsoft.Win32;

namespace Where_did_Bob_Go_VA.Command_NS

public class CommandLeave : BaseCommand, ICommand
{
    public void Execute(Context context, string command, string[] parameters)
    {
        // registry. får vi fra vores Game.cs fil
        // GetCommand trækker commandedn leave
        // placeholder trækker fra CommandTalk, som viser hvilken NPC man snakker med
        // så kører den StopConversation() for at afslutte samtalen
        (registry.GetCommand("leave")).PlaceHoldder.StopConversation();
    }
}
