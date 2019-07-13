using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffAdditionAutoCreate : MonoBehaviour
{//生成buff,每个Buff不能和敌人一起生成，不能重合。每个buff的生成几率不同，厉害的生成几率小。算法不会。。。。。。
    public float Time=3;
    [Header("Buff种类")]
    public GameObject BuffAddition_1;
    public GameObject BuffAddition_2;
    public GameObject BuffAddition_3;
    public GameObject BuffAddition_4;
    [Header("Buff种类产生的几率")]
    public float Buff_1 = 0.1f;
    public float Buff_2 = 0.05f;
    public float Buff_3 = 0.01f;
    public float Buff_4 = 0.001f;
    [Header("Buff各个种类开始出现时间")]
    public float BuffTime_1 = 2f;
    public float BuffTime_2 = 5f;
    public float BuffTime_3 = 7f;
    public float BuffTime_4 = 8f;
    // Start is called before the first frame update
    void Awake()
    {
        Buff_1 = Buff_1 * 200;
        Buff_2 = Buff_2 * 200;
        Buff_3 = Buff_3 * 200;
        Buff_4 = Buff_4 * 200;


        CreateBuff(BuffAddition_1);
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.time % 3 == 0)
        {
            OptVariety();
        }
    }
    private void OptVariety() {
        float x = TimeManager.time;
        //sin(x) + 2cos(x) + cos(2x + 58) + 2sin(3x - 30) + 3sin(6x - 20) - 4cos(5x - 40) + 2*sin(x * x + 120) + 4*cos(6*x - 48);
        x = Mathf.Sin(x) + 2 * Mathf.Cos(2 * x + 58) + 2 * Mathf.Sin(3 * x - 30) + 3 * Mathf.Sin(6*x - 20) - 4 * Mathf.Cos(5 * x - 40) + 2 * Mathf.Sin(x * x + 120) + 4 * Mathf.Cos(6 * x - 48);
        float y = Random.value;
        if (y < 0.5f) {
            if (x < Buff_1)
                CreateBuff(BuffAddition_1);
        }
        else if (y < 0.7f)
        {
            if (x < Buff_2)
                CreateBuff(BuffAddition_2);
        }
        else if (y < 0.87f)
        {
            if (x < Buff_3)
                CreateBuff(BuffAddition_3);
        }
        else{
            if (x < Buff_4)
                CreateBuff(BuffAddition_4);
        }

    }
    private void CreateBuff(GameObject buffAddition) {
        Instantiate(buffAddition, new Vector3(this.transform.position.x, this.transform.position.y, this.transform.position.z), Quaternion.AngleAxis(180, Vector3.up));
    }
}
