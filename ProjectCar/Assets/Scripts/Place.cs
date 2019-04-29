using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour {

	[SerializeField]
	private Material mat;

	[SerializeField]
	private float rad;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Collider[] hitColliders = Physics.OverlapSphere(this.transform.position, rad);
		for (int i = 0; i < hitColliders.Length; i++)
		{
			if (hitColliders[i].gameObject.tag == "car")
				this.gameObject.GetComponent<Renderer>().material = mat;
		}	
	}

	/*void OnDrawGizmosSelected()
    {
        // Draw a yellow sphere at the transform's position
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, rad);
	}*/

}
