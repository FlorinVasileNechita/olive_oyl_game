using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	GameController sGameController;

	void Awake()
	{
		sGameController = GameController.Instance;
	}

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Coin::OnTriggerEnter2D Coin collected");
		sGameController.CoinCollected ();
		Destroy (gameObject);
	}
}
