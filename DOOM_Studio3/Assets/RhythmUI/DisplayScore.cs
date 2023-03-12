using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text comboText;
    public Animator textanimator;

    // Start is called before the first frame update
    void Start()
    {
        comboText.text = GameScoreManager.comboCount.ToString() + "X";
       
    }

    // Update is called once per frame
    void Update()
    {
        
        comboText.text = GameScoreManager.comboCount.ToString() + "X";
        textanimator.Play("Pulse");

        if (GameScoreManager.missed == true)
        {
            GameScoreManager.comboCount = 0;
            comboText.text = "0X";
            textanimator.Play("blank");
        }
    }
}
