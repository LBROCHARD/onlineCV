using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoBarrel : MonoBehaviour
{
    public GameObject Barrel;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
           Barrel.GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
