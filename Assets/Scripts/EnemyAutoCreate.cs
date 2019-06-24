using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoCreate : MonoBehaviour
{
    private float x = 26;
    private int a;
    private float b;
    private int guidao1, guidao2, guidao3;
    public GameObject enemyPrefab;
    //敌人生成距离
    [Tooltip("前后距离")]
    public int juli1 = 10;
    [Tooltip("左右距离")]
    public int juli2 = 2;
    [Tooltip("刚开始生成敌人时间间隔")] 
    public float Times=2;
    private float times; //保存Times的初值
    //获取EnemyManager的x值
    private float positionx;
    //轨道距离
    [HideInInspector]
    public static float kuandu;
      
    // Start is called before the first frame update
    private void Awake()
    {
        positionx = this.transform.position.x;
        guidao1 = 2;
        guidao2 = guidao1 + 1;
        guidao3 = guidao2 + 1;
    }
    private void Start()
    {
        kuandu = positionx + juli2;
        times = Times;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (TimeManager.time >= Times)
        {
            Times += times;
            if (times > 0.65f)
            {
                times -= Random.value * 0.1f;
            }
            CreateEnemy(enemyPrefab);
        }
    }
    //生成敌人
    void CreateEnemy(GameObject enemy) {
        a = guidaoPandun();
        if (a == guidao1)
            b = positionx-juli2;
        else if (a == guidao2)
            b = positionx;
        else if (a == guidao3)
            b = positionx+juli2;
        else if (a == -1) { b = positionx; }
        Instantiate(enemy, new Vector3(b, 0, this.transform.position.z), Quaternion.AngleAxis(180, Vector3.up));
      
    }
    //判断三个轨道哪一个，后期找一个算法替代随机
    int guidaoPandun() {
        x = 13*(5*Mathf.Sin(TimeManager.time)+3*Mathf.Cos(TimeManager.time+0.783f)+8*Mathf.Cos(TimeManager.time+1.047f)+2*Mathf.Sin(TimeManager.time+0.628f)+ 9 * Mathf.Sin(TimeManager.time + 0.935f));
        Random.InitState((int)x);
        double a = Random.value;
       
        if (a <0.3)
            return guidao1;
        else if (a <0.6)
            return guidao2;
        else if (a <0.9)
            return guidao3;
        
        return -1;
    }

}
