using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BeatManager : MonoBehaviour
{
    public GameObject Gun;
    [SerializeField] private float bpm;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Intervals[] _intervals;
    

    private void Start()
    {
        Gun = GameObject.FindGameObjectWithTag("Gun");
    }

    private void Update()
    {
        foreach (Intervals interval in _intervals)
        {
            float sampledTime = (audioSource.timeSamples / (audioSource.clip.frequency * interval.GetIntervalLength(bpm))); //gets time in intervals //gets time elapsed in intervals
            interval.NewIntervalCheck(sampledTime); //sends over the number
        }

    }

   
}
