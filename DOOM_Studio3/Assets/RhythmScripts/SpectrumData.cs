using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpectrumData : MonoBehaviour
{
    public float spectrumvalue;
    public int spectrumSensitivity;
    public AudioListener beatMap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float[] spectrum = new float[256]; // where spectrum data is stored

        AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        for (int i = 0; i < spectrum.Length; i++)
        {
            float tmp = spectrum[i] * spectrumSensitivity; //just to make values outputted easier to read

            if(tmp >= 1)
            {
                gameObject.transform.rotation = Quaternion.Euler(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
            }
            Debug.Log(tmp);
        }
    }
}
