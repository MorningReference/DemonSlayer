using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCamera : MonoBehaviour
{
    public delegate void ParallaxCameraDelegate(float deltaMovement);
    public ParallaxCameraDelegate onCameraTranslate;
    [SerializeField] private float oldPosition;

    public FrameSwitch edge;
    void Start()
    {
        oldPosition = transform.position.x;
    }
    void Update()
    {
        if (transform.position.x != oldPosition)
        {
            if (onCameraTranslate != null)
            {
                float delta = oldPosition - transform.position.x;
                onCameraTranslate(delta);
            }
            oldPosition = transform.position.x;
        }
        if (edge.isForward == true)
        {
            oldPosition = 28;
            edge.isForward = false;
        }
        else if (edge.isBack == true)
        {
            oldPosition = 15;
            edge.isBack = false;
        }
    }
}
