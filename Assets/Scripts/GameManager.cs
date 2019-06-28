using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{//作为中间类，各个类的枢纽

    public static float Speed;//整体游戏速度

    private void Start()
    {
        Speed = EnemyManager.Speeds;
    }

}
