using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour {

    Rigidbody rb;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    private LayerMask groundLayer;

    [SerializeField]
    private float jumpForce = 10;

    bool CheckGround()
    {
        Collider[] col = Physics.OverlapSphere(groundCheck.position, 0.7f, groundLayer);
        if(col.Length > 0)
        {
            return true;
        }
        return false;
    }

	void Start () {
        rb = GetComponent<Rigidbody>();
	}
    
	void Update () {        
        if (Input.GetButtonDown("Jump") && CheckGround())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
	}

    void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(groundCheck.position, 0.7f);
    }

}
