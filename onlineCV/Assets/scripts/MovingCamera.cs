using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MovingCamera : MonoBehaviour
{
    public CinemachineFreeLook cinemachineCamera;
    public Transform player;
    public LayerMask layer;
    public float distanceRight = 2.5f;
    public float distanceBack = 2.5f;
    public float cameraSpeedUp = 0.01f;
    public float cameraSpeedDown = 0.01f;
    private float basicValue = 0.6f;
    private float upValue = 0.95f;


    void Update () 
    {
        RaycastHit hit;
        Vector3 playerUp = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);

        if (Physics.Raycast(playerUp, Vector3.right, out hit, distanceRight, layer) || Physics.Raycast(playerUp, Vector3.back, out hit, distanceBack, layer))
        {
            Debug.DrawRay(playerUp, Vector3.right * hit.distance, Color.yellow);
            cinemachineCamera.m_YAxis.Value = Mathf.Lerp(cinemachineCamera.m_YAxis.Value, upValue, cameraSpeedUp);
        } else {
            cinemachineCamera.m_YAxis.Value = Mathf.Lerp(cinemachineCamera.m_YAxis.Value, basicValue, cameraSpeedDown);
        }
    }

}
