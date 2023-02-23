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
    private ShootingHandler shootingHandler;

    [SerializeField]
    bool ableToShoot;

    private void Start()
    {
        ableToShoot = false;
        shootingHandler = gameObject.GetComponent<ShootingHandler>();
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
            ableToShoot = true;
            Destroy(this.gameObject, 3f);
            
        }
        else
        {
            ableToShoot = false;
        }
    }

    void Shooting()
    {
        if (ableToShoot == true && Input.GetMouseButtonDown(0))
        {
            Destroy(this.gameObject);
        }
    }
    

}
