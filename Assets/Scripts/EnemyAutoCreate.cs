using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoCreate : MonoBehaviour
{
    private float x=26;
    private int a;
    private float b;
    private int guidao1, guidao2, guidao3;
    public GameObject enemyPrefab;
    //敌人生成距离
    public int juli1 = 10;//前后距离
    public int juli2 = 2;//左右距离
    //生成敌人间隔
    public float Times=2;
    //获取EnemyManager的x值
    private float positionx;
      
    // Start is called before the first frame update
    private void Awake()
    {
        positionx = this.transform.position.x;
        guidao1 = 2;
        guidao2 = guidao1 + 1;
        guidao3 = guidao2 + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (TimeManager.time >= Times)
        {
            Times += Times;
            CreateEnemy(enemyPrefab);
        }
    }

    void CreateEnemy(GameObject enemy) {
        a = guidaoPandun();
        if (a == guidao1)
            b = positionx-juli2;
        else if (a == guidao2)
            b = positionx;
        else if (a == guidao3)
            b = positionx+juli2;
        else if (a == -1) { b = positionx; }
        Instantiate(enemy, new Vector3(b, 0, juli1),Quaternion.AngleAxis(180,Vector3.up));
        enemy.AddComponent<EnemySpeed>();
    }
    //判断三个轨道哪一个，后期找一个算法替代随机
    int guidaoPandun() {
        x = 13*(5*Mathf.Sin(x)+3*Mathf.Cos(x+0.783f)+8*Mathf.Cos(x+1.047f)+2*Mathf.Sin(x+0.628f)+ 9 * Mathf.Sin(x + 0.935f));
        Random.InitState((int)x);
        double a = Random.value;
        Debug.Log(a);
        if (a <0.3)
            return guidao1;
        else if (a <0.6)
            return guidao2;
        else if (a <0.9)
            return guidao3;
        
        return -1;
    }

}
