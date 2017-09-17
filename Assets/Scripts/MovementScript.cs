using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    private Rigidbody rb;
    private Animator anim;
    private float horizontalInput;
    private Vector3 moveVector;
    private bool isRight = true;

    [SerializeField]
    private float moveSpeed = 5;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        moveVector = new Vector3();
    }

    void flip()
    {
        transform.localEulerAngles = new Vector3(0, 90 * Mathf.Sign(horizontalInput), 0);
    }
    
    void HorizontalMovement()
    {
        moveVector.x = horizontalInput * moveSpeed * Time.deltaTime;
        rb.MovePosition(rb.position + moveVector);
        if(Mathf.Abs(horizontalInput) > 0.1f)
        {
           flip(); 
           anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }
    }

	void FixedUpdate ()
    {
        HorizontalMovement();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");        
    }

}
