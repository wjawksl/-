using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0; // 0 degree
    
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10; // 10 degree
        }
        transform.Rotate(0, 0, this.rotSpeed);
        this.rotSpeed *= 0.99f;
    }
}
