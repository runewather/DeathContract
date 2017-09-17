using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    private Rigidbody rb;
    private float horizontalInput;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void HorizontalMovement()
    {
        rb.MovePosition(rb.position);
    }

	void FixedUpdate ()
    {
	    	
	}

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
    }

}
