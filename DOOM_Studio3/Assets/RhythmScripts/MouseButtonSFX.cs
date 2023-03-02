using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseButtonSFX : MonoBehaviour
{
    public AudioSource sfx;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            sfx.Play();
        }
    }
}
