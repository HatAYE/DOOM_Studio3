using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class Shooting : MonoBehaviour
{                    
    [SerializeField] float maxShootingDistance;
    public bool ableToShoot;
    public float beatGracePeriod;
    private Intervals intervals;
    public GameObject reticleImage;
    public GameObject maincam;

    public float shootingGracePeriod;

    private void Start()
    {
        maincam = GameObject.FindGameObjectWithTag("MainCamera");
    }
    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(maincam.transform.position, transform.forward, out hit, maxShootingDistance) && Input.GetMouseButtonDown(0))
        {
            Debug.DrawLine(transform.position, hit.point, Color.green);
            if (hit.collider.CompareTag("Enemy"))
            {
                Destroy(hit.collider.gameObject);
                
            }
        }

        shootingGracePeriod -= Time.deltaTime;
        if (shootingGracePeriod < 0)
        {
            
            Debug.Log("disabled shooting rawr");
            reticleImage.GetComponent<Image>().color = Color.red;
            ableToShoot = false;
        }
       
    }
    public void EnableShooting()
    {
        shootingGracePeriod = 1;
        Debug.Log("shootingtimer activated");
        reticleImage.GetComponent<Image>().color = Color.green;
        ableToShoot = true;
    }
   
    public void StopShooting()
    {
        Debug.Log("disabled shooting rawr");
        reticleImage.GetComponent<Image>().color = Color.red;
        ableToShoot = false;
    }

    /*private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawRay(transform.position, Vector3.forward);
    }*/
}
