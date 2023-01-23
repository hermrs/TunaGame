using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameratakip : MonoBehaviour
{
    public Vector3 offset;
    public Transform karakter;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = karakter.position + offset;
    }
}
