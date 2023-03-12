using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Agent : MonoBehaviour
{
    public ActionBase defaultAction;
    public float ChargeStatus;
    public GameObject RechargeStation;
    Planner planner;

    public List<string> AquiredPrerequisites;
    ActionBase CurrentState;

    private void Awake()
    {
        foreach(ActionBase a in planner.Actions)
        {
            a.Setup();
        }
    }

    void Start()
    {

    }
    
    void Update()
    {
        //if (AquiredPrerequisites.Contains("Working"))
        //{
        //    planner.GetActionList("World Clean", this);
        //}
        //else
        //{
        //    planner.GetActionList("Working", this);
        //}
    }
}
