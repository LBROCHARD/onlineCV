using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayingObject : ZoomableObject
{
    public Transform[] screens;

    void Start()
    {
        foreach(Transform transf in screens)
        {
            transf.GetComponent<Renderer>().enabled = false;;
        }
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

            foreach(Transform transf in screens)
            {
                transf.GetComponent<Renderer>().enabled = false;
            }
            
            zoomObject.GetComponent<Renderer>().enabled = false;
        }
    }

}
