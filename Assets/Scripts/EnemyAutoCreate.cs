using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAutoCreate : MonoBehaviour
{
    private int x=1;
    private int a,b;
    private int guidao1, guidao2, guidao3;
    public GameObject enemyPrefab;
    //敌人生成距离
    public int juli = 10;
    //生成敌人间隔
    public float Times=2;
    private float time = 0;
      
    // Start is called before the first frame update
    private void Awake()
    {
        guidao1 = 2;
        guidao2 = guidao1 + 1;
        guidao3 = guidao2 + 1;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (time >= Times)
        {
            time = 0;
            CreateEnemy(enemyPrefab);
        }
    }

    void CreateEnemy(GameObject enemy) {
        a = guidaoPandun();
        if (a == guidao1)
            b = -1;
        else if (a == guidao2)
            b = 0;
        else if (a == guidao3)
            b = 1;
        else if (a == -1) { b = 0; }
        Instantiate(enemy, new Vector3(b, 0, juli),Quaternion.AngleAxis(180,Vector3.up));
        Debug.Log(a+ "   " +b);

    }

    int guidaoPandun() {
        int a=x*x*x+x + 1;
        x++;
        if (a % guidao1 == 0)
            return guidao1;
        if (a % guidao2 == 0)
            return guidao2;
        if (a % guidao3 == 0)
            return guidao3;
        
        return -1;
    }

}
