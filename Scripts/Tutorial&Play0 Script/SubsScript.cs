using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SubsScript : MonoBehaviour
{
    public GameObject textBox;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheSequence());        
    }

    IEnumerator TheSequence()
    {
        yield return new WaitForSeconds(2);
        textBox.GetComponent<Text>().text = "We have a tornado warning and a severe thunderstorm warning.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "The National Weather Service has issued a tornado warning.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Make sure you're indoors and away from doors and windows.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "The warning is in effect.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";
        yield return new WaitForSeconds(1);
        textBox.GetComponent<Text>().text = "Get ready for the typhoon.";
        yield return new WaitForSeconds(3);
        textBox.GetComponent<Text>().text = "";

        SceneManager.LoadScene("Tutorial");

    }
}
