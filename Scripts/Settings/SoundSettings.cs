using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSettings : MonoBehaviour
{
    public GameObject canvas;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activatePanel()
    {
        canvas.SetActive(true);
    }

    public void deactivatePanel() {
        canvas.SetActive(false);
    }
}
