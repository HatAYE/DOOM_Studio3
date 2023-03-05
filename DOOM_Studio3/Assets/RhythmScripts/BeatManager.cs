using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Events;

public class BeatManager : MonoBehaviour
{
    public List<float> beatTimings;
    public GameObject Gun;
    public GameObject noteParentOnCanvas;
    public Vector3 noteInitialSpawn;
    public GameObject NotePrefab;
    #region audio stuffs
    [SerializeField] private float bpm;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Intervals[] _intervals;
    [SerializeField] float sampleRateOfMidi = 44100;
    [SerializeField]
    int beatsElapsedCounter = 0;
    public float AudioTime;
    #endregion 

    public float AnimationOffset;
    public int beatCounter;

    private void Start()
    {
        Debug.Log(Application.dataPath);
        Gun = GameObject.FindGameObjectWithTag("Gun");
    }

    private void Update()
    {
        foreach (Intervals interval in _intervals)
        {
            float sampledTime = (audioSource.timeSamples / (audioSource.clip.frequency * interval.GetIntervalLength(bpm))); //gets time in intervals //gets time elapsed in intervals
            interval.NewIntervalCheck(sampledTime); //sends over the number
        }

        beatTimings = ReadBeatTimingsTXT(Application.dataPath + "/RhythmUI/Beatmap.txt", 128, 140);

        if ((beatTimings[beatCounter] < checkAudioTime(audioSource) + AnimationOffset))
        {
            if ((beatCounter % 2) == 1)
            {
                //GameObject currentNote = Instantiate(NotePrefab, noteInitialSpawn, Quaternion.identity, noteParentOnCanvas.transform); //instantiates new prefab and assigns it as current note, spawns it at spawn point + default rotation
                //currentNote.GetComponent<Animator>().StartPlayback();
                //Debug.Log(beatTimings[beatCounter]);

            }
            beatCounter++;
        }



    }

    // Function reads given .txt file line by line, converts strings to floats and returns a list of float.
    private List<float> ReadBeatTimingsTXT(string FilePath,int PPQ, int BPM)
    {
        // Reader that reads .txt file
        StreamReader Reader = new StreamReader(FilePath);
        // List that holds all the data read by the reader
        List<float> Timings = new List<float>();
        // Miliseconds per tick
        float msPerTick = 60000 / (BPM * PPQ);
        // Loops untill file ends
        while (!Reader.EndOfStream)
        {
            // Assigns data read by reader to LineData
            string LineData = Reader.ReadLine();
            // Converts time in ticks to time in ms and adds to Timings List
            Timings.Add(float.Parse(LineData) * msPerTick);
        }
        // Stops Reader
        Reader.Close();
        // Returns timings
        return Timings;
    }


    float checkAudioTime(AudioSource audioSourceInput)
    {

        AudioTime = (audioSourceInput.timeSamples / sampleRateOfMidi); //PCM over the sample rate of the midi file
        AudioTime = AudioTime * 1000; //converting to ms
        //Debug.Log(AudioTime);
        return AudioTime;

    }









}
