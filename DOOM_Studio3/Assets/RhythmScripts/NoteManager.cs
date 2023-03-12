using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class NoteManager : MonoBehaviour
{

    public Vector2 ReticlePosition;

    public bool onBeat;
    public AudioSource sfxtest;

    public bool badhit;
    public bool goodhit;
    public bool perfecthit;
    public bool misshit;



    // Update is called once per frame
    void Update()
    {

        //if (onBeat == true && Input.GetMouseButtonDown(0))
        //{
        //  Destroy(this.gameObject);
        //}

        if (Input.GetMouseButtonDown(0) && badhit == true)
        {
            Debug.Log("bad hit!!!");
            GameScoreManager.badHitCount++;
            GameScoreManager.comboCount++;
            Destroy(this.gameObject);
            //Debug.Log(GameScoreManager.badHitCount);
        }
        if (Input.GetMouseButtonDown(0) && goodhit == true)
        {
            GameScoreManager.GoodHitCount++;
            GameScoreManager.comboCount++;
            Debug.Log("good hit!!!");
            Destroy(this.gameObject);

        }
        if (Input.GetMouseButtonDown(0) && perfecthit == true)
        {
            sfxtest.Play();
            GameScoreManager.perfectHitCount++;
            GameScoreManager.comboCount++;
            Debug.Log("perfect hit!!!");
            Destroy(this.gameObject);
        }

    }

    public void canclick()
    {
        onBeat = true;
        badhit = true;
        GameScoreManager.allActionsEnabled = true;
        //Debug.Log("true");
    }

    public void cantclick()
    {
        onBeat = false;
        GameScoreManager.allActionsEnabled = false;
        //Debug.Log("false");

    }

    public void BadHit()
    {
        GameScoreManager.missed = false;
        badhit = true;
       
    }

    public void GoodHit()
    {
        GameScoreManager.missed = false;
        badhit = false;
        goodhit = true;

      
    }


    public void perfectHit()
    {
        GameScoreManager.missed = false;
        goodhit = false;
        perfecthit = true;
     
           
    }

    public void miss()
    {
        GameScoreManager.missed = true;
        GameScoreManager.missHitCount++;
        Destroy(this.gameObject);
    }

    public void destroyNote()
    {
        Destroy(this.gameObject);
    }


}
