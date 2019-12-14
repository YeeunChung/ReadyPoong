using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove_Tutorial : MonoBehaviour
{
    public int playerSpeed = 2;
    public static bool isStopped = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isStopped)
            return;
        if (Input.GetButton("Fire1"))
        {
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }
}
