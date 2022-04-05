using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayingObject : ZoomableObject
{
    public Transform[] screens;
    public bool isCvBox = false;

    void Start()
    {
        foreach(Transform transf in screens)
        {
            transf.GetComponent<Renderer>().enabled = false;;
        }
        focusCamera.enabled = false;
        zoomObject.GetComponent<Renderer>().enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = true;
            player.focusCamera = focusCamera;

            if (isCvBox == true) {
                player.inCvBox = true;
            }

            foreach(Transform transf in screens)
            {
                transf.GetComponent<Renderer>().enabled = true;
            }

            zoomObject.GetComponent<Renderer>().enabled = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = false;

            if (isCvBox == true) {
                player.inCvBox = false;
            }

            foreach(Transform transf in screens)
            {
                transf.GetComponent<Renderer>().enabled = false;
            }
            
            zoomObject.GetComponent<Renderer>().enabled = false;
        }
    }

}
