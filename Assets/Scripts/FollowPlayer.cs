using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public GameObject player; //used for referencing car from camera
    private Vector3 offset = new Vector3(0, 6, -14 ); //declaring offset for camera
    public float rotationSpeed; //rotation speed variable WORKS
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate() //change to Late Update to smooth camera and car
    {   //offset the camera to behind the player by adding a vector to players position
        //WORKS transform.position = player.transform.position + offset;
        float horizontalInput = Input.GetAxis("Horizontal"); //gets L/R input to variable WORKS
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); //rotate around y-axis/(.up) WORKS
    }
}
