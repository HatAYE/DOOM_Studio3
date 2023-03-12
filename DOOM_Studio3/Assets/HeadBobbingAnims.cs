using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadBobbingAnims : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Bobbing();
        }

        if (Input.GetKey(KeyCode.S))
        {
            Bobbing();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Bobbing();
        }

        if (Input.GetKey(KeyCode.D))
        {
            Bobbing();
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            notBobbing();
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            notBobbing();
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            notBobbing();
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            notBobbing();
        }
    }

    void Bobbing()
    {
        gameObject.GetComponent<Animator>().SetBool("bobbing", true);
    }

    void notBobbing()
    {
        gameObject.GetComponent<Animator>().SetBool("bobbing", false);
    }
}
