using UnityEngine;
using System.Collections;

public class Heart : MonoBehaviour {

	GameController sGameController;

	void Awake()
	{
		sGameController = GameController.Instance;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Heart::OnTriggerEnter2D Heart collected");
		sGameController.HeartCollected ();
		Destroy (gameObject);
	}
}
