using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomableObject : MonoBehaviour
{
    public Camera focusCamera;

    void Start()
    {
        focusCamera.enabled = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = true;
            player.focusCamera = focusCamera;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player"){
            player player = other.gameObject.GetComponent<player>();
            player.inCollider = false;
        }
    }
}
