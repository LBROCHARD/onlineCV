using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayingObject : ZoomableObject
{

    public Transform screen;
    public Transform screen2;

    void Start()
    {
        screen.GetComponent<Renderer>().enabled = false;
        screen2.GetComponent<Renderer>().enabled = false;
        focusCamera.enabled = false;
        zoomObject.GetComponent<Renderer>().enabled = false;
    }

    void Update(){}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = true;
            player.focusCamera = focusCamera;
            screen.GetComponent<Renderer>().enabled = true;
            screen2.GetComponent<Renderer>().enabled = true;
            zoomObject.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = false;
            screen.GetComponent<Renderer>().enabled = false;
            screen2.GetComponent<Renderer>().enabled = false;
            zoomObject.GetComponent<Renderer>().enabled = false;
        }
    }

}
