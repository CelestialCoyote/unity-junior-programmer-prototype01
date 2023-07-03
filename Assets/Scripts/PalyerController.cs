using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PalyerController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 20);
    }
}
