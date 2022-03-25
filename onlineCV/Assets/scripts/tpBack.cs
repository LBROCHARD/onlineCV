using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tpBack : MonoBehaviour
{
    void Start(){}
    void Update(){}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.TpBack();
        }
    }
}
