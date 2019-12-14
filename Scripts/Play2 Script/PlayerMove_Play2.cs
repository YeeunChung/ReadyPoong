using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class PlayerMove_Play2: MonoBehaviour
{

    public Text Count;
    public Text status;
    public string sceneName;
    public static float WindowCount; //현재까지 총 테이핑한 창문 수
    public int gameStart_2 = 0;
    public int playerSpeed = 2;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    public static bool isStopped = false;

    // Start is called before the first frame update
    void Start()
    {
        Count = gameObject.GetComponentInChildren<Text>();
        WindowCount = 0;
        status = GameObject.FindGameObjectWithTag("status").GetComponentInChildren<Text>();
        status.enabled = false;

        PlayerPrefs.SetInt("IsGameStart_2", 0);
    }


    // Update is called once per frame
    void Update()
    {
        int gameStart_2 = PlayerPrefs.GetInt("IsGameStart_2");

        if (isStopped)
            return;

        if (Input.GetButton("Fire1") && gameStart_2 == 1)
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
        
        if (WindowCount <= 10)
        {
            Count.text = Mathf.FloorToInt(WindowCount) + "";

            if (WindowCount == 10) 
            {
                audioSource.PlayOneShot(clip, volume);
                status.enabled = true;
                Invoke("ChangeSceneToPlay3", 2.0f);
            }

        }
        
    }

    void ChangeSceneToPlay3() {
        SceneManager.LoadScene(sceneName);
    }
    
}
