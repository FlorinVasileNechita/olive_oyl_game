using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider)
	{
		Debug.Log ("Coin::OnTriggerEnter2D Coin collected");
		GameController.Instance.CoinCollected ();
		Destroy (gameObject);
	}
}
