using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;



public class FoundObject : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume = 0.5f;
    public int _item = 0;
    public string sceneName="";

    public GameObject selectedObjects;
    // Start is called before the first frame update

    void Start()
    {
        //audioSource = GetComponent<AudioSource>();
        PlayerPrefs.SetInt("item", 0);
    }

    public void SelectedObject()
    {
        Color color = selectedObjects.GetComponent<Image>().color;
        color.a = 255; //0f
        //color.a = 0f;
        print(color);
        selectedObjects.GetComponent<Image>().color = color;
        print(selectedObjects.GetComponent<Image>());
    }

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("SurvivalTool"))
        {
            //audioSource.PlayOneShot(impact);
            //audioSource.Play();
            audioSource.PlayOneShot(clip, volume);
            Destroy(other.gameObject);
            
            _item = PlayerPrefs.GetInt("itemSum");
            _item++;
            PlayerPrefs.SetInt("itemSum", _item);

        }


    }

    public void OnPointerDown(PointerEventData eventData)
    {
        PlayerMove_Play3.isStopped = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove_Play3.isStopped = false;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
