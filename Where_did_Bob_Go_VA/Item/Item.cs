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

namespace Where_did_Bob_Go_VA.Item_NS
{

    public class Item
    {
        // Attributes 
        public string Name { get; }
        public string Description { get; }

        // Constructor 
        public Item(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        // Method
        public virtual string Use()
        {
            return $"You found a {Name}.";
        }
    }

}