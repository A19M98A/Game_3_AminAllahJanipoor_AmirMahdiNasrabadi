using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public Rigidbody ball;
    public int power = 500;
    public float x;
    public float z;
    public float y;
    public float siny;
    public float cosy;

    public RawImage[] balls;
    public int countOfball = 10;

    // Start is called before the first frame update
    void Start()
    {
    }

    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonUp("Fire1") && countOfball != 0 )
        {
            Vector3 t = transform.position;
            Quaternion p = transform.rotation;
            Rigidbody instance = Instantiate(ball, t, p) as Rigidbody;
            Vector3 fwd = transform.TransformVector(Vector3.forward);
            instance.AddForce(fwd * power);
            balls[countOfball - 1].enabled = false;
            countOfball--;
        }

    }


}
