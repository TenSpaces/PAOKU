using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffAdditionManager : MonoBehaviour
{
    private float speeds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        speeds = GamesManager.Speed;
        transform.position = transform.position + new Vector3(0, 0, -speeds);
       
    }
}
