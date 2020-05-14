using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BallConttorel : MonoBehaviour
{

    public int pointOfBall = 0;
    // Start is called before the first frame update
        void Start()
    {
        Destroy(this.gameObject,3);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider collider) 
        {
            if(collider.gameObject.tag.Split('_')[0] == "grean" || collider.gameObject.tag.Split('_')[0] == "red"|| collider.gameObject.tag.Split('_')[0] == "blue"){
                Destroy(this.gameObject);
                pointOfBall += int.Parse(collider.gameObject.tag.Split('_')[1]);
                Debug.Log(pointOfBall);
            }
        }
}
 