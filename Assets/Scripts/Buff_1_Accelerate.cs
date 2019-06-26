using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff_1_Acelerate : MonoBehaviour
{
    private float fixedSpeed;//固定速度


    /// <summary>
    /// 增加一定速度直到物体消失 代码1
    /// </summary>
    /// <param name="fixedSpeed">固定的速度</param>
    /// <returns></returns>
    public float AddFixedSpeed(float fixedSpeed) {
        return fixedSpeed;
    }

    /// <summary>
    /// 物体速度以一定值逐渐增大 代码2
    /// <param name="addSpeed">增加值</param>
    /// </summary>
    public float SpeedEscalating(float addSpeed) {

        return addSpeed;
    }
    /// <summary>
    /// 物体提速后，速度变小但还比原来的大 代码3
    /// </summary>
    /// <param name="ultimateSeed">最后的速度</param>
    /// <param name="currentSpeed">现在的速度</param>
    /// <param name="cutStale">变小的量</param>
    /// <returns></returns>
    public float DownEscalating(float currentSpeed,float ultimateSeed,float cutScale) {
        if (ultimateSeed > currentSpeed)
            currentSpeed -= 0.1f * cutScale;
        return currentSpeed;
    }
}
