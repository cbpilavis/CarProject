using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20.0f;
    private float turnspeed = 30.0f;
    private float horizontalInput; //holds horizontal input
    private float forwardInput; //holds forwards input
    public float rotationSpeed; //rotation speed variable WORKS
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get player input
        //WORKS horizontalInput = Input.GetAxis("Horizontal"); //left and right speed input
        forwardInput = Input.GetAxis("Vertical"); //forwards and backwards speed input
        float horizontalInput = Input.GetAxis("Horizontal"); //gets L/R input to variable WORKS
        //moves car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //rotates the car based on horizontal input
        transform.Rotate(Vector3.up, turnspeed * horizontalInput * Time.deltaTime);

        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime); //rotate around y-axis/(.up) WORKS
        
    }
}
