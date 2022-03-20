using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class computer : MonoBehaviour
{

    public Transform screen;
    public Transform screen2;

    void Start()
    {
        screen.GetComponent<Renderer>().enabled = false;
        screen2.GetComponent<Renderer>().enabled = false;
    }

    void Update(){}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            // Debug.Log("collision with player");
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = true;
            this.gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = true;
            this.gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            // Debug.Log("player is out");
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = false;
            this.gameObject.transform.GetChild(0).GetComponent<Renderer>().enabled = false;
            this.gameObject.transform.GetChild(1).GetComponent<Renderer>().enabled = false;
        }
    }

}
