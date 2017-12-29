using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public GameObject player;
    private Vector3 offset;
	// Use this for initialization
	void Start () {
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    // Late Update function makes sure that it is run after all Update functions have been run.
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}
}
