using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BPMInstantiation : MonoBehaviour
{
    public GameObject notePrfb;
    public Vector3 notespawnpoint;
    public GameObject noteParentOnCanvasg;
    public AudioSource sfxtest;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void instantiateOnInterval()
    {

        GameObject currentNote = Instantiate(notePrfb, notespawnpoint, Quaternion.identity, noteParentOnCanvasg.transform);
        //sfxtest.Play();

    }
}
