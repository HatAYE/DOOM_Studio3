using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    public float noteSpeed;
    public GameObject reticletarget;
    public Vector3 target;
    private Vector3 postDestinationPos;
    private GameObject note; 
    

    [SerializeField]
    bool onBeat;

    private void Start()
    {
        onBeat = false;
       
        note = this.gameObject;
        reticletarget = GameObject.FindGameObjectWithTag("Reticle");
        postDestinationPos = new Vector3(target.x, target.y + 4f, target.z);
        target = reticletarget.transform.position + postDestinationPos;
       
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, noteSpeed * Time.deltaTime);
        Shooting();
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Reticle"))
        {
            onBeat = true;
            Destroy(this.gameObject, 3f);
            
        }
        else
        {
            onBeat = false;
        }
    }

    void Shooting()
    {
        if (onBeat == true && Input.GetMouseButtonDown(0))
        {
            Destroy(this.gameObject);
        }
    }
    

}
