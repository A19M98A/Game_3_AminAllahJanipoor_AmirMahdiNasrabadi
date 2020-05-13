using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Shooter : MonoBehaviour
{
    public Rigidbody ball;
    public int power = 500;
    public float x;
    public float z;
    public float y;
    public float siny;
    public float cosy;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1"))
        {
            Vector3 t = transform.position;
            Quaternion p = transform.rotation;
            //siny = Convert.ToSingle(Math.Sin(p.y));
            //cosy = Convert.ToSingle(Math.Cos(p.y));
            //y = p.y;
            //x = Convert.ToSingle(1f - p.y);
            //t.x += x;
            //z = Convert.ToSingle(p.y);
            //t.z += z;

            Rigidbody instance = Instantiate(ball, t, p) as Rigidbody;
            Vector3 fwd = transform.TransformVector(Vector3.forward);
            instance.AddForce(fwd * power);
        }
    }
}
