using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Where_did_Bob_Go_VA.Command_NS;
using Where_did_Bob_Go_VA.Game_NS;

namespace Where_did_Bob_Go_VA.Command
public class CommandUse : BaseCommand, ICommand
{
    public void Command_use()
    {

    }
    public void Execute(Context context, string command, string[] parameters)
    {
        context.MakeDone();
    }
}