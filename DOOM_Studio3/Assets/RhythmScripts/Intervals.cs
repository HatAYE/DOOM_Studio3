using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class Intervals
{

    [SerializeField] private float kicks;
    [SerializeField] private UnityEvent beatTrigger;
    private int lastInterval;
    private Shooting shooting;
    
    public float GetIntervalLength(float bpm) //length of current beat 
    {
        return 60f / (bpm * kicks); //beats per min, multiplying by kicks allows for quarter, half etc beats.
    }

    public void NewIntervalCheck(float interval)
    {
        shooting = GameObject.FindGameObjectWithTag("Gun").GetComponent<Shooting>();
        if (Mathf.FloorToInt(interval) != lastInterval)
        {
            lastInterval = Mathf.FloorToInt(interval); //rounding to whole number to check if weve hit a ebat
            beatTrigger.Invoke();
            Debug.Log("beat trigger invoked");

        }
        else
        {
            shooting.StopShooting();
        }
    }
}
