using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpinPropeller : MonoBehaviour
{
    public GameObject Propeller;
    private float turnSpeed = 100.0f;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Rotate(0, 0, turnSpeed);
    }
}
