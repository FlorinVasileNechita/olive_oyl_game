using UnityEngine;
using System.Collections;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		float 	distanceFromCamera;
		distanceFromCamera = (transform.position - Camera.main.transform.position).z;
		float earthYPoint = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceFromCamera)).y;
		
		Rigidbody2D rigidBody = GetComponent<Rigidbody2D> ();
		rigidBody.position = new Vector3 (transform.position.x,
		                                  earthYPoint,
		                                  transform.position.z);
	}
}
