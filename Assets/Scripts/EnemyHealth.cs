using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            afterDeath();
            Destroy(this);

        }
    }

    //敌人死亡效果
    private void afterDeath() { }
}
