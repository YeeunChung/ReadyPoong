using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseNPlay : MonoBehaviour
{
    public bool btnState;
    public Text text;
    public Button Pause;

    // Start is called before the first frame update
    void Start()
    {
        btnState = true;
    }

    public void PressButton() {

        if (btnState)
        {
            btnState = false;
            gameObject.GetComponentInChildren<Text>().text = "Play";
            PlayerPrefs.SetInt("IsPause", 1);

        }
        else {
            btnState = true;
            gameObject.GetComponentInChildren<Text>().text = "Pause";
            PlayerPrefs.SetInt("IsPause", 0);
        }
    }
}
