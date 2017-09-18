using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {
    
    [SerializeField]
    private Transform player;

    [SerializeField]
    private float smoothCameraRate = 0.5f;

    private Vector3 lastPlayerPosition;
    private Vector3 cameraPostion;
    private Vector3 offset;

    void Start()
    {
        offset = player.transform.position - transform.position;
    }

	void FixedUpdate ()
    {        
        transform.position = Vector3.Lerp(transform.position, player.position - offset, smoothCameraRate);
	}
}
