using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MusicControl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Slider MusicBackVolume;
    public Slider MusicController;
    //public AudioSource MusicAudio;
    public float MusicBackVol;
  

    public void MusicVolumeSlider()
    {
      //  MusicAudio.volume = MusicBackVolume.value;
        MusicBackVol = MusicBackVolume.value;
        PlayerPrefs.SetFloat("MusicBackvol", MusicBackVol); // 이전 상태 유지
        AudioListener.volume = MusicBackVol;
        if (MusicBackVol == 0.0 || MusicBackVol == 1.0)
            ;
        else
            PlayerMove_Play3.isStopped = true;


    }

    // Start is called before the first frame update
    void Start()
    {
        MusicBackVol = PlayerPrefs.GetFloat("MusicBackvol", 1f); // 1f : 키의 값이 비어있을 때 1 값을 가져오기
        MusicBackVolume.value = MusicBackVol;
      //  MusicAudio.volume = MusicBackVolume.value;
    }

    // Update is called once per frame
    void Update()
    {
        MusicVolumeSlider();
    }


    public void OnPointerDown(PointerEventData eventData) {
        PlayerMove_Tutorial.isStopped = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        PlayerMove_Tutorial.isStopped = false;
    }

}
