using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    public RawImage[] Hills;
    public RawImage[] keys;

    public Text txtKey;
    public int countOfKey = 0;
    public int countOfHill = 3;
    public bool[] hitKeys = new bool[] { false, false };
    void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "ball" && countOfHill != 0)
        {
            Debug.Log(hit.gameObject.tag);
            Hills[countOfHill - 1].enabled = false;
            countOfHill--;
        }

        if (hit.gameObject.tag.Split('_')[0]== "key")
        {
            if(!hitKeys[int.Parse(hit.gameObject.tag.Split('_')[1])])
            {
                hitKeys[int.Parse(hit.gameObject.tag.Split('_')[1])] = true;
                Debug.Log(hit.gameObject.tag);
                hit.gameObject.GetComponent<Renderer>().enabled = false;
                txtKey.text = (++countOfKey).ToString();
            }
        }

    }
}
