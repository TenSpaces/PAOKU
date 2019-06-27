using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff_2_SlowDown 
{//该类所有方法都会使物体减小

    /// <summary>
    /// 不作任何事情 代码0
    /// </summary>
    public void Nothing()
    {
    }

    /// <summary>
    /// 减少一定速度直到物体消失 代码1
    /// </summary>
    /// <param name="fixedSpeed">固定的速度</param>
    /// <returns></returns>
    public float CutFixedSpeed(float fixedSpeed)
    {
        return fixedSpeed;
    }

    /// <summary>
    /// 物体速度以一定值(米每秒)逐渐减小 代码2
    /// <param name="addSpeed">减小值</param>
    /// </summary>
    public float SpeedSlowing(float cutSpeed)
    {

        return cutSpeed*Time.deltaTime;
    }

   
}
