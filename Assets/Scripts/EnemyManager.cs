using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [Tooltip("速度改变间隔")]
    public float Jiange = 8f;
    private Buff_1_Acelerate accelerate;
    private Buff_2_SlowDown slowDown;
    private EnemySpeed originSpeed;
    private float speeds;

    //决定物体的速度处于哪种，0代表初始速度；1代表加速；2代表减速
    public static int panduan=0;
    //Buff_1_Accelerate的状态,分别对应不同的加速
    public static int buff_1 = 1;
    public float Buff_1_1_1_fixedSpeed = 1f;//第一个Buff的第一个buff函数的第一个参数，以下的也是这样
    public float Buff_1_2_1_addSpeed = 0.1f;
    public float Buff_1_3_2_ultimateSpeed = 0.5f;
    public float Buff_1_3_2_cutScale = 0.2f;

    //Buff_2_SlowDown的状态，分别对应不同的减速
    public static int buff_2 = 1;
    public float Buff_2_1_1_fixedSpeed = 1f;//第一个Buff的第一个buff函数的第一个参数，以下的也是这样
    public float Buff_2_2_1_slowSpeed = 0.1f;

    void Start()
    {
        
        slowDown = new Buff_2_SlowDown();
        originSpeed = new EnemySpeed();
        speeds= originSpeed.CreatSpeed(Jiange);

        accelerate = new Buff_1_Acelerate();
        Buff_1_3_2_ultimateSpeed = speeds + Buff_1_3_2_ultimateSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(panduan==0)
            transform.position = transform.position + new Vector3(0, 0, -speeds);
        if (panduan == 1) {
            if (buff_1 == 1)
                speeds -= accelerate.AddFixedSpeed(Buff_1_1_1_fixedSpeed);
            else if (buff_1 == 2)
                speeds -= accelerate.SpeedEscalating(Buff_1_2_1_addSpeed);
            else if (buff_1 == 3)
                speeds = accelerate.DownEscalating(speeds, Buff_1_3_2_ultimateSpeed, Buff_1_3_2_cutScale);
            else if (buff_1 == 0)
                accelerate.Nothing();
                
        }
        if (panduan == 2) {
            if (buff_2 == 1)
                speeds += slowDown.CutFixedSpeed(Buff_2_1_1_fixedSpeed);
            else if (buff_2 == 2)
                speeds += slowDown.SpeedSlowing(Buff_2_2_1_slowSpeed);
            else if (buff_2 == 0)
                slowDown.Nothing();
        }
    }
}
