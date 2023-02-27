using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrapplingHook : MonoBehaviour
{
    [SerializeField] Vector3 targetEnemy;
    [SerializeField] float maxGrapplingDistance;
    [SerializeField] float minGrapplingDistance;
    [SerializeField] float dashingSpeed;
    [SerializeField] bool canGrab=true;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("bruh");
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxGrapplingDistance) && Input.GetKey(KeyCode.Space))
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.collider.CompareTag("Enemy"))
            {
                Debug.Log("AA");
                GameObject enemy= hit.collider.gameObject;
                float distance = Vector3.Distance(transform.position, enemy.transform.position);
                transform.position = Vector3.Lerp(transform.position, hit.point, dashingSpeed * Time.deltaTime);
            }
            /*Debug.Log("hi");
            targetEnemy = hit.point;
            //need to make whatever object it hit the new target
            if (hit.collider.CompareTag("Enemy") && distance <= maxGrapplingDistance && canGrab==true)
            {
                Debug.Log("collider?");  
                //Vector3.MoveTowards(transform.position, targetEnemy, distance);
                if (distance<= minGrapplingDistance)
                {
                    Debug.Log("should stop dashing");
                    canGrab = false;
                    
                }
            }*/
        }


    }
}
