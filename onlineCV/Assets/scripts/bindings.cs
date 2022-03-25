using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bindings : MonoBehaviour
{
    void Start(){}
    void Update(){}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            this.gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            this.gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
        }
    }

}
