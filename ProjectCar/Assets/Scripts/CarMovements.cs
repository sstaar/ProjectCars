using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovements : MonoBehaviour
{

	[SerializeField]
	private Transform goal;

	[SerializeField]
	private Transform car;

	[SerializeField]
	private float speed;

	// Use this for initialization
	void Start () {
		car = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = Vector3.MoveTowards(car.position, goal.position, speed * Time.deltaTime);
		car.position = newPos;
		//Vector3 look = new Vector3(goal.position.x, goal.position.y, -goal.position.z);
		car.LookAt(goal);
		if (this.transform.position == goal.position)
			goal = goal.gameObject.GetComponent<Target>().target;
	}
}
