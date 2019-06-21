using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpeed : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform transforms;
    private float speed;
    void Start()
    {
        transforms = this.transform;
        speed = CreatSpeed();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 0, -speed);
    }
    //生成速度,后期找一个算法替代随机
    private float CreatSpeed() {
        float x = transforms.position.x;
        x = 0.02f * (0.5f * Mathf.Sin(x) + 0 * Mathf.Cos(x + 0.783f) + 0.02f * Mathf.Cos(x + 1.047f) + 0.12f * Mathf.Sin(x + 0.628f) + 0.1f * Mathf.Sin(x + 0.935f));
        return Mathf.Abs(x);
    }
}
