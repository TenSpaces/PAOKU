using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueShakeCamera_1 : MonoBehaviour
{
    [Tooltip("振动时间")]
    public float ShakeTime = 1f;
    private float shakeTime;

    private float shakeDelta = 0.005f;
    public Camera cam;
    public static bool isshakeCamera = true;
    // Use this for initialization
    void Start()
    {
        shakeTime = ShakeTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (isshakeCamera)
        {
            if (shakeTime > 0)
            {
                shakeTime -= Time.deltaTime;
                if (shakeTime <= 0)
                {
                    cam.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
                    isshakeCamera = true;
                    shakeTime = ShakeTime;
                }
                else
                {
                    
                        cam.rect = new Rect(shakeDelta * (-1.0f + 2.0f * Random.value), shakeDelta * (-1.0f + 2.0f * Random.value), 1.0f, 1.0f);

                 
                }
            }
        }


    }

}
