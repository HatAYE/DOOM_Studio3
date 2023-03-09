using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Keys : MonoBehaviour
{
    [SerializeField] int keysInInventory;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    { if (GameScoreManager.)
        if (other.gameObject.CompareTag("Key"))
        {
            Destroy(other.gameObject);
            keysInInventory += 1;
        }
        
        if (other.gameObject.CompareTag("Door") && keysInInventory>= 1)
        {
            other.gameObject.transform.position += new Vector3 (0,2.5f,0);
            keysInInventory -= 1;
            
        }
    }
}
