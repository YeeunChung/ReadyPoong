using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Water_Play1 : MonoBehaviour
{
    Text status;
    Canvas cvs;
    int pressBtnState;

    void Start()
    {
        PlayerPrefs.SetInt("IsWaterTapClick", 0);
        cvs = gameObject.GetComponentInChildren<Canvas>();
        status = cvs.GetComponentInChildren<Text>();
    }

    void Update()
    {
        pressBtnState = PlayerPrefs.GetInt("IsPause");

        if (pressBtnState == 0)
        {
            int waterTapClick = PlayerPrefs.GetInt("IsWaterTapClick");
            float waterHeight = transform.position.y;
            PlayerPrefs.SetFloat("WaterHeight", waterHeight);

            if (waterHeight < 0.52f)
                status.text = "Not Enough";
            else if (waterHeight >= 0.52f && waterHeight <= 0.61f)
                status.text = "Enough!";
            else if (waterHeight > 0.61f)
            {
                status.text = "Too Much";
                Invoke("ChangeSceneFail", 2.0f);
            }

            if (waterTapClick == 1 && waterHeight < 0.785f)
            {
                transform.position += new Vector3(0, 0.1f * Time.deltaTime, 0);
            }
        }
    }

    void ChangeSceneFail()
    {
        SceneManager.LoadScene("BadEnding_1");
    }
}
