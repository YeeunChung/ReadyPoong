using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timeText;
    private float time;
  

    // Start is called before the first frame update
    void Awake()
    {
        
    }
    void Start() {

        PlayerPrefs.SetInt("IsGameStart", 0);
        PlayerPrefs.SetInt("IsGameStart_2", 0);
        PlayerPrefs.SetInt("IsGameStart_3", 0);
        PlayerPrefs.SetInt("IsPause", 0);

        // 제한시간 쓰면 됨
        if (SceneManager.GetActiveScene().name == "Play_1")
            time = 30f;
        if (SceneManager.GetActiveScene().name == "Play_2")
            time = 45f;
        if (SceneManager.GetActiveScene().name == "Play_3")
            time = 60f;

        
        timeText = gameObject.GetComponentInChildren<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        int gameStart = PlayerPrefs.GetInt("IsGameStart");
        int gameStart_2 = PlayerPrefs.GetInt("IsGameStart_2");
        int gameStart_3 = PlayerPrefs.GetInt("IsGameStart_3");

        int btnPause = PlayerPrefs.GetInt("IsPause");
  
        //Play_1
        if (time > 0 && gameStart==1 && btnPause!=1){
            time -= Time.deltaTime;
        }
        //Play_2
        if (time > 0 && gameStart_2 == 1 && btnPause != 1){
            time -= Time.deltaTime;
        }
        //Play_3
        if (time > 0 && gameStart_3 == 1 && btnPause != 1)
        {
            time -= Time.deltaTime;
        }

        timeText.text = Mathf.Ceil(time).ToString();
        if (Mathf.Ceil(time) == 0)
        {
            if (SceneManager.GetActiveScene().name == "Play_1")
                SceneManager.LoadScene("BadEnding_1");
            if (SceneManager.GetActiveScene().name == "Play_2")
                SceneManager.LoadScene("BadEnding_2");
            if (SceneManager.GetActiveScene().name == "Play_3")
                SceneManager.LoadScene("BadEnding_3");
        }
    }
}
