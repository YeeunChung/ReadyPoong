using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClicktoPlayMusic : MonoBehaviour
{
    public AudioClip SoundToPlay;
    AudioSource audio;
    int radioClickCount = 0;
    public Text status;


    void Start()
    {
        audio = GetComponent <AudioSource>();
        status = gameObject.GetComponentInChildren<Text>();
    }

    void OnMouseDown()
    {
        if (radioClickCount % 2 == 0)
        {
            audio.PlayOneShot(SoundToPlay);
            status.text = "Radio ON!";
        }
        else
        {
            audio.Stop();
            status.text = "Radio OFF!";
        }
        radioClickCount++;
    }
}
