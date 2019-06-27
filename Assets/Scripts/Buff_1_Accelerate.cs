using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff_1_Acelerate 
{//该类所有方法都会使速度增大

    /// <summary>
    /// 不做任何事情 代码0
    /// </summary>
    public void Nothing() {
    }

    /// <summary>
    /// 增加一定速度直到物体消失 代码1
    /// </summary>
    /// <param name="fixedSpeed">固定的速度</param>
    /// <returns></returns>
    public float AddFixedSpeed(float fixedSpeed) {
        return fixedSpeed;
    }

    /// <summary>
    /// 物体速度以一定值（米每秒）逐渐增大 代码2
    /// <param name="addSpeed">增加值</param>
    /// </summary>
    public float SpeedEscalating(float addSpeed) {

        return addSpeed*Time.deltaTime;
    }
    /// <summary>
    /// 在速度比初始速度大的情况下减小速度(米每秒），但还比原来的大 代码3
    /// </summary>
    /// <param name="ultimateSeed">最后的速度</param>
    /// <param name="currentSpeed">现在的速度</param>
    /// <param name="cutStale">变小的量</param>
    /// <returns></returns>
    public float DownEscalating(float currentSpeed,float ultimateSeed,float cutScale) {
        if (ultimateSeed > currentSpeed)
            currentSpeed -= cutScale*Time.deltaTime;
        return currentSpeed;
    }
}
