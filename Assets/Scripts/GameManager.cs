using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{//游戏中重要的的静态量枢纽

    public static float Speed;//游戏速度

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Speed = EnemyManager.Speeds;
    }
}
