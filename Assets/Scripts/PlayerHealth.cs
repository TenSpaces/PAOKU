using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [Tooltip("玩家血量")]
    public static float Health = 100f;
    private float health;
    [Tooltip("伤害值")]
    public float Damage = 1f;
    // Start is called before the first frame update
    void Start()
    {
        health = Health;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Enemy1")) {
            health -= Damage;
            ContinueShakeCamera_1.panduan();
        }
    }
    //死亡效果
    public void AfterDeath() {

    }
}
