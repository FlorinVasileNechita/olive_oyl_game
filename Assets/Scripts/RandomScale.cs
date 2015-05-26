using UnityEngine;
using System.Collections;

public class RandomScale : MonoBehaviour {

	public float mMaxSize;
	public float mMinSize;
	// Use this for initialization
	void Awake () {
		float randomScale = Random.Range (mMinSize, mMaxSize);;
		transform.localScale = new Vector3 (randomScale, randomScale, 1.0f);
	}
}
