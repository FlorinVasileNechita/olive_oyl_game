using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	GameController sGameController;

	void Awake()
	{
		sGameController = GameController.Instance;
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Obstacle::OnCollisionEnter2D GameOver()");
		Die ();
	}
	
	void Die()
	{
		Debug.Log("Obstacle::Die()");
		sGameController.Die ();
	}
}
