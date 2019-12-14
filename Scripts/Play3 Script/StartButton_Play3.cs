using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartButton_Play3 : MonoBehaviour
{

    public Canvas canvas;

    // Start is called before the first frame update
    void Start()
    {
        canvas = GameObject.Find("Canvas_Tutorial_3").GetComponent<Canvas>();

    }

    public void StartTheScene()
    {
        PlayerPrefs.SetInt("IsGameStart_3", 1);
        // Canvas Disable3
        canvas.enabled = false;
    }
}
