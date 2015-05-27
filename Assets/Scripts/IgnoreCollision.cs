using UnityEngine;
using System.Collections;

public class IgnoreCollision : MonoBehaviour {

	public GameObject mObjectToNotCollide;

	void Awake()
	{
		Collider2D selfCollider = GetComponent<Collider2D> ();
		Collider2D otherCollider = mObjectToNotCollide.GetComponent<Collider2D> ();

		Physics2D.IgnoreCollision (selfCollider,
		                          otherCollider,
		                          true);
	}
}
