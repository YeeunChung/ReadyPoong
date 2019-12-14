using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton_Play2 : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {
        canvas = GameObject.Find("Canvas_Tutorial_2").GetComponent<Canvas>();
       // Debug.Log(canvas.enabled);
    }
    public void StartTheScene()
    {
        PlayerPrefs.SetInt("IsGameStart_2", 1);
        // Canvas Disable
        canvas.enabled = false;
    }
}
