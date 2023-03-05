using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    #region Health System
    public GameObject[] HealthHeartsUI;
    public int PlayerHealth;
    #endregion

    void Start()
    {
        
    }

    
    void Update()
    {
        #region Health System
        if (PlayerHealth <= 0)
        {
            //GameOver
        }
        #endregion
    }

    void TakeDamage()
    {
        PlayerHealth--;
    }

    void Heal()
    {
        PlayerHealth ++;
    }
}
