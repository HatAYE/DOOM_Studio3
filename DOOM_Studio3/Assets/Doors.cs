using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doors : MonoBehaviour
{

    [SerializeField] int keysInInventory;


    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        keysInInventory = GameScoreManager.keysInInventory;

    }
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Door") && GameScoreManager.keysInInventory >= 1)
            {
            other.gameObject.transform.position += new Vector3(0, 2.5f, 0);
                GameScoreManager.keysInInventory -= 1;

            }
    }
    
}
