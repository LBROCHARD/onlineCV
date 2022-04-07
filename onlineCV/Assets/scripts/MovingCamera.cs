using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingCamera : MonoBehaviour
{
    public Camera mainCamera;
    public Transform player;
    public GameObject walls;
    public GameObject cube;

    void Update () 
    {
        // if (walls.GetComponent<MeshCollider>().bounds.Contains( new Vector3( player.position.x + 2.5f, player.position.y, player.position.z) ) ) {
        //     print("point is inside walls");
        // }
        RaycastHit hit;
        Vector3 playerUp = new Vector3(player.transform.position.x, player.transform.position.y + 1, player.transform.position.z);
        if (Physics.Raycast(playerUp, player.transform.TransformDirection(Vector3.forward), out hit, 2.5f, walls.layer))
        {
            Debug.DrawRay(playerUp, player.transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Hit");
            cube.transform.position = hit.transform.position;
        }
    }

}
