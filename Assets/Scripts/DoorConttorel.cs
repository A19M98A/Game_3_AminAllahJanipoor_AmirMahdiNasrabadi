using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorConttorel : MonoBehaviour
{
    GameObject FPSController;
    float time;
    void Start()
    {
        gameObject.GetComponent<Animator>().enabled = false;
        FPSController = GameObject.FindGameObjectsWithTag("FPSController")[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (Math.Abs(FPSController.transform.position.x - transform.position.x) < 3 && Math.Abs(FPSController.transform.position.z - transform.position.z) < 3)
        {
            gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<Animator>().Play("DoorOpen");
        }
        else
        {
            gameObject.GetComponent<Animator>().Play("DoorClose");
        }
    }
}
