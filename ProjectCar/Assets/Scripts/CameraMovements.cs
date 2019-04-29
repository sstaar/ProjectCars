using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovements : MonoBehaviour {

	[SerializeField]
	private Transform cam;

	[SerializeField]
	private Transform center;

	[SerializeField]
	private float speed;

	// Use this for initialization
	void Start () {
		cam = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		cam.RotateAround(center.position,Vector3.up, speed * Time.deltaTime);
	}
}
