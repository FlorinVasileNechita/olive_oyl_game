using UnityEngine;
using System.Collections;

public class RandomVelocity : MonoBehaviour {

	public Vector2 mVelocityMin, mVelocityMax;
	void Awake()
	{
		Vector2 randomVelocity = new Vector2 (Random.Range (mVelocityMin.x, mVelocityMax.x),
		                                     Random.Range (mVelocityMin.y, mVelocityMax.y));

		GetComponent<Rigidbody2D>().velocity = randomVelocity;
	}
}
