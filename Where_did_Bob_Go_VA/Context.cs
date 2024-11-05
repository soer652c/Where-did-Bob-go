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

namespace Where_did_Bob_Go_VA.Game_NS
{


    /* Context class to hold all context relevant to a session.
     */
    public class Context
    {
        Space current;
        bool done = false;

        public Context(Space node)
        {
            current = node;
        }

        public Space GetCurrent()
        {
            return current;
        }

        public void Transition(string direction)
        {
            Space next = current.FollowEdge(direction);
            if (next == null)
            {
                Console.WriteLine("You are confused, and walk in a circle looking for '" + direction + "'. In the end you give up 😩");
            }
            else
            {
                current.Goodbye();
                current = next;
                current.Welcome();
            }
        }

        public void MakeDone()
        {
            done = true;
        }

        public bool IsDone()
        {
            return done;
        }
    }


}

