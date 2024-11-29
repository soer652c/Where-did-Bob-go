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
        string PreviousName;

       public Context(ref World world)
        {
            current = world.GetEntry();
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

        public string GetPreviousName()
        {
            return PreviousName;
        }

        public void Transition(string direction)
        {
            if (string.IsNullOrEmpty(direction))
            {
                Console.WriteLine("You are confused, and walk in a circle looking for + direction");
            }
            else if (char.IsLower(direction[0]) && current.CheckEdge(direction))
            {
                PreviousName = (current).name;
                Space next = current.FollowEdge(direction);
                current.Goodbye();
                current = next;
                current.Welcome(PreviousName);
            }
            else if (char.IsUpper(direction[0]) && current.CheckEdge(direction))
            {
                PreviousName = (current).name;
                Space next = current.FollowEdge(direction);
                current.Goodbye();
                current = next;
                current.Welcome(PreviousName);
            }
            else
            {
                Console.WriteLine("Couldn't find the location '" + direction + "'.");
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
            return world.NPCTopRight(); //World.klassen i NPCleft
        }
    }


}

