using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueShakeCamera_1 : MonoBehaviour
{
    [Tooltip("振动时间")]
    public static float ShakeTime = 1f;
    private static float shakeTime;

    private float shakeDelta = 0.005f;
    public Camera cam;
    private static bool isShakeCamera = false;
    // Use this for initialization
    void Start()
    {
        shakeTime = ShakeTime;

    }

    // Update is called once per frame
    void Update()
    {
        if (isShakeCamera)
        {
            if (shakeTime > 0)
            {
                shakeTime -= Time.deltaTime;
                if (shakeTime <= 0)
                {
                    cam.rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);
                    isShakeCamera = false;
                    shakeTime = ShakeTime;
                }
                else
                {
                        cam.rect = new Rect(shakeDelta * (-1.0f + 2.0f * Random.value), shakeDelta * (-1.0f + 2.0f * Random.value), 1.0f, 1.0f);

                }
            }
        }


    }
    public static void panduan() {
        isShakeCamera = true;
        shakeTime = ShakeTime;
    }

}
