using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimations : MonoBehaviour
{
    private Animator gunanimator;

    // Start is called before the first frame update
    void Start()
    {
        gunanimator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (GameScoreManager.allActionsEnabled == true)
        {
            gunanimator.SetBool("abletoshoot", true);
        }
        else
        {
            gunanimator.SetBool("abletoshoot", false);
        }
    }
}
