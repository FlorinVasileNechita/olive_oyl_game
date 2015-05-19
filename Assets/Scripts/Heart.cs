using UnityEngine;
using System.Collections;

public class Heart : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Heart::OnTriggerEnter2D Heart collected");
		GameController.Instance.HeartCollected ();
		Destroy (gameObject);
	}
}
