using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RechargeAction : ActionBase
{
    public override List<string> Prerequisites { get; set; }
    public override List<string> Effects { get; set; }

    public override void Setup()
    {
        Prerequisites = new List<string>();
        Effects = new List<string>();
    }

    public override string DoAction(Agent agent)
    {
        return "Completed";
    }
}