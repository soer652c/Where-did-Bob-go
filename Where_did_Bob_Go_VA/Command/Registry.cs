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

namespace Where_did_Bob_Go_VA.Command_NS
{


    /* Command registry
     */

    public class Registry
    {
        Context context;
        ICommand fallback;
        Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

        public Registry(Context context, ICommand fallback)
        {
            this.context = context;
            this.fallback = fallback;
        }

        public void Register(string name, ICommand command)
        {
            commands.Add(name, command);
        }

        public void Dispatch(string line)
        {
            string[] elements = line.Split(" ");
            string command = elements[0];
            string[] parameters = GetParameters(elements);
            (commands.ContainsKey(command) ? GetCommand(command) : fallback).Execute(context, command, parameters);
        }

        public ICommand GetCommand(string commandName)
        {
            return commands[commandName];
        }

        public string[] GetCommandNames()
        {
            return commands.Keys.ToArray();
        }

        // helpers

        private string[] GetParameters(string[] input)
        {
            string[] output = new string[input.Length - 1];
            for (int i = 0; i < output.Length; i++)
            {
                output[i] = input[i + 1];
            }
            return output;
        }
    }

}

