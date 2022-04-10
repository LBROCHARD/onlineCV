using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public Rigidbody body;
    public Animator animator;

    public float speed = 6f;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Camera mainCam;
    public Camera cam2;
    public Camera focusCamera;

    public bool canMove = true;
    public bool inCollider = false;
    public bool inCvBox = false;

    public GameObject canvas;
    private CanvasScript canvasScript;

    void Start()
    {
        canMove = false;
        mainCam.enabled = true;
        cam2.enabled = false;
        canvasScript = canvas.GetComponent<CanvasScript>();
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
        else if ( Input.GetMouseButtonDown(0) )
        {
            if (inCollider == true && canMove == false)
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
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
                transform.rotation = Quaternion.Euler(0f, angle, 0f);

                body.MovePosition( body.position + direction * speed * Time.fixedDeltaTime);
                animator.SetBool("isMoving", true);
            }
        }
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
    
    public void ChangeCamera()
    {
        mainCam.enabled = !mainCam.enabled;
        // cam2.enabled = !cam2.enabled;
        focusCamera.enabled = !focusCamera.enabled;
        canMove = !canMove;
        canvasScript.ShowingEscape();
    }

    public void TpBack()
    {
        transform.position = new Vector3( 0f, 1f, -3f);
        transform.rotation = Quaternion.identity;
        if ( canMove == false){
            ChangeCamera();
        }
    }
}

// the basic values of the "input axis name" in the camera is : "Mouse Y" and "Mouse X"
