using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Shooting : MonoBehaviour
{
    [SerializeField] float maxShootingDistance;
    private Intervals intervals;
    public float shootingGracePeriod;

    public Animator gunanimator;

    private void Start()
    {
      
    }

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, maxShootingDistance) && Input.GetMouseButtonDown(0) && GameScoreManager.allActionsEnabled == true)
        {
            Debug.DrawLine(transform.position, hit.point, Color.green);
            if (hit.collider.CompareTag("Enemy"))
            {
    
                Destroy(hit.collider.gameObject);
                gunanimator.SetTrigger("shooting");

            }
            

        }
        
    }
}
