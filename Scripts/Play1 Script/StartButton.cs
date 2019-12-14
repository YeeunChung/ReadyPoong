using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton : MonoBehaviour
{
    public Canvas canvas;

    void Start()
    {
        canvas = GameObject.Find("Canvas_Tutorial").GetComponent<Canvas>();
        Debug.Log(canvas.enabled);
    }
    public void StartTheScene()
    {
        PlayerPrefs.SetInt("IsGameStart", 1);
        // Canvas Disable
        canvas.enabled = false;
    }
}
