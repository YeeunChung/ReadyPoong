using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove_Play1 : MonoBehaviour
{
    public int playerSpeed = 2;
    public int count = 0;
    int radioClickCount = 0;
    int valveClickCount = 0;
    int waterTapClickCount = 0;
    GameObject waterSmall;
    bool flag = false;
    public Text status;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;

    void Start()
    {
        PlayerPrefs.SetInt("IsGameStart", 0);
        waterSmall = GameObject.FindGameObjectWithTag("WaterSmall");
        status = GameObject.FindGameObjectWithTag("MainCamera").GetComponentInChildren<Text>();
        status.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        int gameStart = PlayerPrefs.GetInt("IsGameStart");

        if (Input.GetButton("Fire1") && gameStart == 1)
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }

        if (Input.GetMouseButtonDown(0) && gameStart == 1)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (Physics.Raycast(ray, out hitInfo))
            {
                // Radio Click 시
                if (hitInfo.collider.gameObject.tag == "Radio")
                {
                    Debug.Log("click radio");
                    if (radioClickCount % 2 == 0)
                    {
                        count++;
                        Debug.Log("count: " + count);
                    }
                    else
                    {
                        count--;
                        Debug.Log("count: " + count);
                    }
                    radioClickCount++;
                }

                // GasValve Click 시
                else if (hitInfo.collider.gameObject.tag == "GasValve")
                {
                    Debug.Log("click valve");
                    if (valveClickCount % 2 == 0)
                    {
                        count++;
                        Debug.Log("count: " + count);
                    }
                    else
                    {
                        count--;
                        Debug.Log("count: " + count);
                    }
                    valveClickCount++;
                }

                // WaterTap Click 시
                else if (hitInfo.collider.gameObject.tag == "WaterTap")
                {
                    Debug.Log("click water tap");
                    if (waterTapClickCount % 2 != 0)
                    {

                        float waterHeight = PlayerPrefs.GetFloat("WaterHeight");
                        Debug.Log(waterHeight);

                        if (waterHeight >= 0.52 && waterHeight <= 0.61)
                        {
                            if (!flag) count++;
                            Debug.Log("count: " + count);
                            flag = true;
                        }
                        else if (waterHeight > 0.61 && flag)
                        {
                            count--;
                            Debug.Log("count: " + count);
                        }
                    }
                    waterTapClickCount++;
                }
            }
        }

        if (count == 3)
        {
            audioSource.PlayOneShot(clip, volume);
            status.enabled = true;
            Invoke("ChangeScenePlay2", 2.0f);
        }
    }

    void ChangeScenePlay2()
    {
        SceneManager.LoadScene("Play_2");
    }
}
