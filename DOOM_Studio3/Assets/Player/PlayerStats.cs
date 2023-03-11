using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Linq;

public class PlayerStats : MonoBehaviour
{
    #region Health System
    public GameObject HealthHeartPrefab;
    public GameObject HeartParent;
    public Stack<GameObject> HealthHeartsUI = new Stack<GameObject>();
    public int PlayerHealth;
    public int PlayerMaxHealth;
    public Texture FullHeart;
    public Texture EmptyHeart;
    #endregion


    void Start()
    {
        for (int i = 0; i < PlayerMaxHealth; i++)
        {
            HealthHeartsUI.Push(Instantiate(HealthHeartPrefab,
                new Vector3(HeartParent.transform.position.x + (i * 25),
                HeartParent.transform.position.y,
                HeartParent.transform.position.z),
                Quaternion.identity,
                HeartParent.transform));
        }
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

        HealthHeartsUI.Pop().GetComponent<Image>().image = EmptyHeart;
    }

    void Heal()
    {
        PlayerHealth++;

        HealthHeartsUI.Push(Instantiate(HealthHeartPrefab,
            new Vector3(HeartParent.transform.position.x + (PlayerHealth - 1 * 25),
            HeartParent.transform.position.y,
            HeartParent.transform.position.z),
            Quaternion.identity,
            HeartParent.transform));
    }
}
