using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    	
    }

    private float speed = 12.0f;
    private float turnSpeed = 6.0f;
    private float horizontalInput;
    private float forwardInput;
    // Update is called once per frame
    void Update()
    {
    	horizontalInput = Input.GetAxis("Horizontal") * turnSpeed;
    	forwardInput = Input.GetAxis("Vertical") * speed;

    	//Moves the car forward
    	transform.Translate(Vector3.forward * Time.deltaTime * forwardInput);

    	//Turns the car
    	transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }

}