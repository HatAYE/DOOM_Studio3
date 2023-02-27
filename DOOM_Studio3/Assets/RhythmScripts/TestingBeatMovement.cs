using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TestingBeatMovement : MonoBehaviour
{
    float pulseSize = 1.15f;
    float returnSpeed = 5f;
    private Vector3 startSize;
    

    private void Start()
    {
        //startSize = transform.localScale;
    }
    private void Update()
    {
        //transform.localScale = Vector3.Lerp(transform.localScale, startSize, Time.deltaTime * returnSpeed);
    }
    public void spinToBeat()
    {
       // gameObject.transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        //transform.localScale = startSize * pulseSize;
       
    }
    public void ChangeReticleColor()
    {

    }

   

}
