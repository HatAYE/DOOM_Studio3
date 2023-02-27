using System.Collections;
using System.Collections.Generic;
using System.IO;
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

        List<int> BeatTimings = ReadBeatTimingsTXT("D:/Uni/Projects/DOOM_Studio3/DOOM_Studio3/Assets/RhythmUI/Beatmap.txt");

        foreach (int Timing in BeatTimings)
        {
            Debug.Log(Timing);
        }
    }

    private void Update()
    {
        foreach (Intervals interval in _intervals)
        {
            float sampledTime = (audioSource.timeSamples / (audioSource.clip.frequency * interval.GetIntervalLength(bpm))); //gets time in intervals //gets time elapsed in intervals
            interval.NewIntervalCheck(sampledTime); //sends over the number
        }

    }

    // Function reads given .txt file line by line, converts strings to ints and returns a list of ints.
    private List<int> ReadBeatTimingsTXT(string FilePath)
    {
        // Reader that reads .txt file
        StreamReader Reader = new StreamReader(FilePath);
        // List that holds all the data read by the reader
        List<int> Timings = new List<int>();

        // Loops untill file ends
        while (!Reader.EndOfStream)
        {
            //Assigns data read by reader to LineData
            string LineData = Reader.ReadLine();
            //Converts LineData into int and adds to Timings List
            Timings.Add(int.Parse(LineData));
        }
        // Stops Reader
        Reader.Close();
        // Returns timings
        return Timings;
    }

}
