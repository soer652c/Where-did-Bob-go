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
using System.Xml.Linq;
using System.ComponentModel.Design;
using System.Transactions;

namespace Where_did_Bob_Go_VA.Game_NS
{


    /* Context class to hold all context relevant to a session.
     */
    public class Context
    {
        Space current;
        bool done = false;
        World world; //Referere til Klassen-word

       public Context(Space node, World world)
        {
            current = node;
            this.world = world; //Her gemmes World referencen så den kan bruges i context
            //klassen
        }
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
            if (string.IsNullOrEmpty(direction))
            {
                Update_TextBox_Main("You are confused, and walk in a circle looking for '" + direction + "'. In the end you give up 😩");
            }
            else if (char.IsLower(direction[0]))
            {

            }
            else
            {
                Space Next = current.FollowEdge(direction);
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

        //NPCLeft()-metoden kalder MPCleft i Worldklasen
        public int NPCleft()
        {
            return world.NPCLeft(); //World.klassen i NPCleft
        }
    }


}

