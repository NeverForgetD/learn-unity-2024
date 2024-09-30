using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    void Start()
    {
        LayerMask mask = LayerMask.GetMask("Water") | LayerMask.GetMask("UI");
        Debug.Log((int)mask);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
