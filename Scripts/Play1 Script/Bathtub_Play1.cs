using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bathtub_Play1 : MonoBehaviour
{
    int waterTapClickCount = 0;
    GameObject waterFall;
    GameObject waterSmall;
    public AudioClip SoundToPlay;
    AudioSource audio;

    void Start()
    {
        waterFall = GameObject.FindGameObjectWithTag("WaterFall");
        waterSmall = GameObject.FindGameObjectWithTag("WaterSmall");
        waterFall.SetActive(false);
        waterSmall.SetActive(false);
        audio = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        if(waterTapClickCount % 2 == 0)
        {
            waterFall.SetActive(true);
            waterSmall.SetActive(true);
            PlayerPrefs.SetInt("IsWaterTapClick", 1);
            audio.PlayOneShot(SoundToPlay);
        }

        else
        {
            waterFall.SetActive(false);
            PlayerPrefs.SetInt("IsWaterTapClick", 0);
            audio.Stop();
        }

        waterTapClickCount++;
    }
}
