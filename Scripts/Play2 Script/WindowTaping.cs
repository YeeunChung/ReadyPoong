using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class WindowTaping : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public AudioSource audioSource;
    public AudioClip clip;
    public Slider tape;
    public float volume = 0.5f;

    //public int windowCount = 0;

    private void Start() {
   
    }

    public void Taping(float taping) {
        tape.value = taping;

        if (taping == 0 || taping == 1)
        {
            //PlayerMove.isStopped = false;


            if (taping > 0.8) {
                PlayerMove_Play2.WindowCount += 1;
            }
        }

        else
            PlayerMove_Play2.isStopped = true;
    }


    public void OnLookItemBox(bool isLookAt) {
      //  Debug.Log(isLookAt);
    }

    public void OnPointerDown(PointerEventData eventData) {
        PlayerMove_Play2.isStopped = true;
        audioSource.PlayOneShot(clip, volume);

    }
    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove_Play2.isStopped = false;
    }


    void Update() {
       // Taping();
    }





}
