using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CvZoom : MonoBehaviour
{
    public Vector3 upPosition;
    public Vector3 downPosition;
    private bool isGoingDown = true;
    public float speed = 0.125f;

    void Update()
    {
        if (isGoingDown == true) {
            transform.position = Vector3.MoveTowards(transform.position, downPosition, speed * Time.deltaTime);

        } else {
            transform.position = Vector3.MoveTowards(transform.position, upPosition, speed * Time.deltaTime);
        }

        if (transform.position == upPosition) {
            isGoingDown = true;

        } else if (transform.position == downPosition) {
            isGoingDown = false;
        }
    }

    
}