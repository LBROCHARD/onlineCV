using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorCamera : MonoBehaviour
{
    void Start()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
        }
    }
}
