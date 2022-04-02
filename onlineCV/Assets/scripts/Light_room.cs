using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_room : MonoBehaviour
{
    public GameObject[ ] lights;

    void Start()
    {
        foreach(GameObject obj in lights)
        {
            obj.transform.GetChild(0).GetComponent<Light>().enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            foreach(GameObject obj in lights)
            {
                obj.transform.GetChild(0).GetComponent<Light>().enabled = true;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            foreach(GameObject obj in lights)
            {
                obj.transform.GetChild(0).GetComponent<Light>().enabled = false;
            }
        }
    }


}
