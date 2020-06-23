using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrameSwitch : MonoBehaviour
{
    public GameObject frame1;
    public GameObject frame2;
    public bool isForward = false;
    public bool isBack = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (frame1.active == true)
        {
            isForward = true;
            frame1.SetActive(false);
            frame2.SetActive(true);
        }
        else if (frame1.active == false)
        {
            frame1.SetActive(true);
            isBack = true;
            frame2.SetActive(false);
        }
    }
}
