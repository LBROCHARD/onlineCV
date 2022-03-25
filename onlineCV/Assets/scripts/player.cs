using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody body;
    public Animator animator;
    public float speed = 6f;
    public Camera mainCam;
    public Camera cam2;
    public Camera focusCamera;
    private bool canMove = true;
    public bool inCollider = false;

    void Start()
    {
        mainCam.enabled = true;
        cam2.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (inCollider == true) 
            {
                ChangeCamera();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            TpBack();
        }
        
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized ;

        if(direction.magnitude >= 0.1f )
        {
            if (canMove == true) 
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);

                body.MovePosition( body.position + direction * speed * Time.fixedDeltaTime);
                animator.SetBool("isMoving", true);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
    
    void ChangeCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        // cam2.enabled = !cam2.enabled;
        focusCamera.enabled = !focusCamera.enabled;
        canMove = !canMove;
    }

    public void TpBack()
    {
        transform.position = new Vector3( 0f, 1f, -3f);
        transform.rotation = Quaternion.identity;
    }
}

// the basic values of the "input axis name" in the camera is : "Mouse Y" and "Mouse X"
