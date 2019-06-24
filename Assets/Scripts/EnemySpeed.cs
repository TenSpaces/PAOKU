using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transforms;
    private float speed;
    //增速倍数
    [SerializeField]
    private float zengsu = 1;
    //间隔时间
    private float jiange;
    public float Jiange = 8f;  //初始间隔
    void Start()
    {
        transforms = this.transform;
        speed = CreatSpeed();
        jiange = Jiange;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, -speed);
    }
    //生成速度,后期找一个算法替代随机
    private float CreatSpeed()
    {
        float x;
        //x = 0.5f * (0.5f * Mathf.Sin(x) + 0 * Mathf.Cos(x + 0.783f) + 0.02f * Mathf.Cos(x + 1.047f) + 0.12f * Mathf.Sin(x + 0.628f) + 0.1f * Mathf.Sin(x + 0.935f));
        if (TimeManager.time % jiange < 0.01f)
        {
            Random.InitState((int)TimeManager.time * 4 + 2);
            jiange = Jiange + Random.value * 10;
            if (Random.value < 0.5)
            {
                zengsu = zengsu + Random.value;
            }
        }

        x = 0.15f * zengsu;
        return Mathf.Abs(x);
    }
}
