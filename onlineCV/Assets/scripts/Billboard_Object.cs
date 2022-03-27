using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard_Object : MonoBehaviour
{
    public Camera mainCamera;

    void LateUpdate()
    {
        // transform.LookAt(mainCamera.transform.position);
        transform.forward = mainCamera.transform.forward;
    }
}
