using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickGasValve : MonoBehaviour
{
    int valveClickCount = 0;
    public Text status;
    public AudioClip SoundToPlay;
    AudioSource audio;

    void Start()
    {
        status = gameObject.GetComponentInChildren<Text>();
        audio = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (valveClickCount % 2 == 0)
        {
            audio.PlayOneShot(SoundToPlay);
            status.text = "Gas Valve Turn Off!";
        }
        else
        {
            audio.PlayOneShot(SoundToPlay);
            status.text = " ";
        }
        valveClickCount++;
    }
}