using UnityEngine;
using System.Collections;

public class DownToEarth : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		float 	distanceFromCamera;
		distanceFromCamera = (transform.position - Camera.main.transform.position).z;
		float earthYPoint = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceFromCamera)).y;

		Renderer renderer = GetComponent<Renderer> (); //FIXME: Ground does not have a renderer component
		float spriteCompensation = 0.0f;
		if (renderer != null)
			spriteCompensation = renderer.bounds.size.y / 2;
		transform.position = new Vector3 (transform.position.x,
		                                 earthYPoint + spriteCompensation,
		                                 transform.position.z);
	}
}
