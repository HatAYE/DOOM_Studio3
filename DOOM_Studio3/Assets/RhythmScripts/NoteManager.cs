using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteManager : MonoBehaviour
{

    public Vector2 ReticlePosition;

    public bool allActionsEnabled;
    public AudioSource sfxtest;



    // Update is called once per frame
    void Update()
    {

        if (allActionsEnabled == true && Input.GetMouseButtonDown(0))
        {
            Destroy(this.gameObject);
        }
      
    }
  
    public void canclick()
    {
        allActionsEnabled = true;
        Debug.Log("true");
       
    }

    public void cantclick()
    {
        allActionsEnabled = false;
        Debug.Log("false");

    }

    public void BadHit()
    {
        GameScoreManager.badHitCount++;
    }

    public void GoodHit()
    {
        GameScoreManager.GoodHitCount++;
    }


    public void perfectHit()
    {
        GameScoreManager.perfectHitCount++;
        sfxtest.Play();
    }

    public void miss()
    {

        GameScoreManager.missHitCount++;
        Debug.Log(GameScoreManager.missHitCount);
        
    }

    public void destroyNote()
    {
        Destroy(this.gameObject);
    }


}
