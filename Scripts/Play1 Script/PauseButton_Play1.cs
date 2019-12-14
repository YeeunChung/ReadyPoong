using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseButton_Play1 : MonoBehaviour
{
    bool bPaused;

    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            bPaused = true;
            Debug.Log("일시정지");
        }
        else
        {
            if (bPaused)
            {
                bPaused = false;
                Debug.Log("일시정지 상태에서 유저 돌아옴");
            }
        }
    }
}
