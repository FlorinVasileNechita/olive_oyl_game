using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	
	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Obstacle::OnCollisionEnter2D GameOver()");
		Die ();
	}
	
	void Die()
	{
		Debug.Log("Obstacle::Die()");
		GameController.Instance.Die ();
	}
}
