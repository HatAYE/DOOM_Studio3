using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SongProgressBar : MonoBehaviour
{
    public AudioClip currentsong;
    public Slider SongProgressSlider;
    public BeatManager bm;
    public float progressspeed = 1f;
    void Start()
    {
        SongProgressSlider.direction = Slider.Direction.LeftToRight;
        SongProgressSlider.minValue = 0;
        SongProgressSlider.maxValue = currentsong.length;
    }

    // Update is called once per frame
    void Update()
    {
        if (SongProgressSlider.value < currentsong.length)
        {
            SongProgressSlider.value += progressspeed * Time.deltaTime;
        }
    }
}
