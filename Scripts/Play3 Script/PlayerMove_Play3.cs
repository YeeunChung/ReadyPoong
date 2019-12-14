using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class PlayerMove_Play3 : MonoBehaviour
{
    public int playerSpeed = 2;
    public int _itemSum = 0;
    public string sceneName;
    public int gameStart_3 = 0;
    public Text status2;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    public static bool isStopped = false;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.SetInt("item", 0);
        PlayerPrefs.SetInt("itemSum", 0);
        PlayerPrefs.SetInt("IsGameStart_3", 0);
        status2 = GameObject.FindGameObjectWithTag("status").GetComponentInChildren<Text>();
        status2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isStopped)
            return;

        _itemSum = PlayerPrefs.GetInt("itemSum");
        int gameStart_3 = PlayerPrefs.GetInt("IsGameStart_3");

       // Debug.Log(itemSum);

        if (Input.GetButton("Fire1") && gameStart_3 == 1)
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }

        if (_itemSum == 5) {

            audioSource.PlayOneShot(clip, volume);
            status2.enabled = true;
            Invoke("ChangeSceneToHappyEnding", 2.0f);
        }

    }

    void ChangeSceneToHappyEnding()
    {
        SceneManager.LoadScene(sceneName);
    }
}
