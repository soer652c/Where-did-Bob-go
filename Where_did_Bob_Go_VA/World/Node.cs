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

namespace Where_did_Bob_Go_VA.World_NS
{


    /* Node class for modeling graphs
     */

    public class Node
    {
        protected string name;
        protected Dictionary<string, Node> edges = new Dictionary<string, Node>();

        public Node(string name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return name;
        }

        public void AddEdge(string name, Node node)
        {
            edges.Add(name, node);
        }

        public virtual Node FollowEdge(string direction)
        {
            return edges[direction];
        }
    }


}
