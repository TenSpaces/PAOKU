﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
	
	int a;
	String b;
	char c;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //现在移动看不出来，后期加上周围环境做参照物应该就能很明显了，相机感觉不要进行缓慢移动，实时移动好点
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)) {
            if(this.transform.position.x>=-EnemyAutoCreate.kuandu)
                this.transform.position += new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (this.transform.position.x <= EnemyAutoCreate.kuandu)
                this.transform.position += new Vector3(1, 0, 0);
        }
    }
}
