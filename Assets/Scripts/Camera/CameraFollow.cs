using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public Transform target;
	public float smoothing = 5.0f;

	private Vector3 offset;
	// Use this for initialization
	void Start () {
		offset = this.transform.position - target.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 camNewPos = target.position + offset;
		this.transform.position = Vector3.Lerp (this.transform.position,
			camNewPos, smoothing * Time.deltaTime);
		
	}
}
