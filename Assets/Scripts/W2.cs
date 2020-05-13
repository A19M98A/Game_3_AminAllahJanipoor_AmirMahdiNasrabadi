using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class W2 : MonoBehaviour
{
    public float Y = 1;
    public float X = 1;
    public float Z = 1;
    public float z0;
    public float maxZ = 5;
    public int N = -1;
    public int t = 1;
    public float sped = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        Y = transform.position.y;
        X = transform.position.x;
        Z = transform.position.z;
        z0 = Z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(X, Y, Z);
        Z += N * sped;
        if (Z*t > maxZ*t)
            N = -N;
        if (Z*t < z0*t)
            N = -N;
    }
}
