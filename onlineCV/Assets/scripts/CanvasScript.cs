using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{

    public Image image1;
    public Image image2;
    public Image escape;
    private bool secondImage = false;
    public Transform player;
    private player playerScript;
    
    void Start()
    {
        playerScript = player.GetComponent<player>();
        image1.GetComponent<Image>().enabled = true;
        image2.GetComponent<Image>().enabled = false;
        escape.GetComponent<Image>().enabled = false;
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)) {

            if (secondImage == false) {
                image1.GetComponent<Image>().enabled = false;
                image2.GetComponent<Image>().enabled = true;
                secondImage = true;
            } else {
                image2.GetComponent<Image>().enabled = false;
                playerScript.canMove = true;
            }
        }
    }

    public void ShowingEscape()
    {
        escape.GetComponent<Image>().enabled = !escape.GetComponent<Image>().enabled;
    }
}
