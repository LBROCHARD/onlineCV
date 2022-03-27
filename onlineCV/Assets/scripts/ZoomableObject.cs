using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomableObject : MonoBehaviour
{
    public Camera focusCamera;
    public Transform zoomObject;


    void Start()
    {
        focusCamera.enabled = false;
        zoomObject.GetComponent<Renderer>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = true;
            player.focusCamera = focusCamera;
            zoomObject.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = false;
            zoomObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
