using System;
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

using static Where_did_Bob_Go_VA.GUI_NS.GUI;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace Where_did_Bob_Go_VA.Item_NS
{
    public class MirrorOfReflection: Item
    {
        List<string> reflection = new List<string>(19);
        int counter = 0;

        string Advice_1 = "Mental health conditions are a clear risk factor e.g depression";
        string Advice_2 = "people showing signs of depression or other\nmood altering conditions are at a increased risk of suicide";
        string Advice_3 = "Repeated usage of substances to ease the day";
        string Advice_4 = "If you are in a environment where suicide is often\nreferenced or is a occurs can spread its influence";
        string Advice_5 = "Varying issues in the family such as childhood abuse,\nneglect and trauma has a negative effect and can lead to suidice attempts";
        string Advice_6 = "Social stigma is a significant risk factor in suicide attempts";
        string Advice_7 = "being excluded due to culture or religion deems someone\ndifferent and by extension excludes them from their peers";
        string Advice_8 = "Being discriminated against is clear risk factor,\nsuch as LGBTQ persons or other minoiritis";
        string Advice_9 = "suffer from discrimination and are at a\nmuch greater risk of suicide attempt";
        string Advice_10 = "People who have been bullied at some point\nin their life are at a greater risk of suicide";
        string Advice_11 = "the trauma can stay long after the bullying as stopped";
        string Advice_12 = "Talking about committing suidice";
        string Advice_13 = "A general lack of a reason to live or feeling hopeless/trapped";
        string Advice_14 = "distancing themselves from social events";
        string Advice_15 = "persons Isolating themselves from family and their peers";
        string Advice_16 = "A change in personality or a loss of interest in their usual activities";
        string Advice_17 = "A sudden improvement in mood, and a willingness to give away\nprized possessions can be a sign that the\n person has decided to take their life and is ready to depart";

        public MirrorOfReflection(string name = "Mirror", string description = "This item can be used to get hints about risk \nfactors and what to look for in people you talk to") : base(name, description)
        {
            Removeable = false;
            reflection.Add(Advice_1); 
            reflection.Add(Advice_2);  
            reflection.Add(Advice_3);
            reflection.Add(Advice_4);
            reflection.Add(Advice_5);
            reflection.Add(Advice_6);
            reflection.Add(Advice_7);
            reflection.Add(Advice_8);
            reflection.Add(Advice_9);
            reflection.Add(Advice_10);
            reflection.Add(Advice_11);
            reflection.Add(Advice_12);
            reflection.Add(Advice_13);
            reflection.Add(Advice_14);
            reflection.Add(Advice_15);
            reflection.Add(Advice_16);
            reflection.Add(Advice_17);

        }
        public string GetAdvice()
        { 
            string temp_text = reflection[counter];
            counter++;
            return temp_text;
        }
        public override string Use()
        {
            return GetAdvice();
        }
    }
}
