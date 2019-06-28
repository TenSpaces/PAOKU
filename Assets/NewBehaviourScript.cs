using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class NewBehaviourScript : MonoBehaviour
{
    Cinemachine.CinemachineVirtualCamera _perlin;
    // Start is called before the first frame update
    void Start()
    {
        _perlin = gameObject.GetComponent<CinemachineVirtualCamera>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
