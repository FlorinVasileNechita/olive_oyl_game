using UnityEngine;
using System.Collections;

public class Player : Singleton<Player> {

	protected Player () {}
	public Vector2 touchForce = new Vector2(0f, 2f);
	private bool isJumpAllowed = true;

	// Use this for initialization
	void Start () {
	
	}
	
	void Awake()
	{
		//Toolbox.RegisterComponent<Player> ();
	}

	public void Jump()
	{
		//Debug.Log("Player::Jump");
		if (isJumpAllowed) 
		{
			Rigidbody2D rigidBody = Player.Instance.GetComponent<Rigidbody2D> ();
			rigidBody.velocity = Vector2.zero;
			rigidBody.AddForce (touchForce, ForceMode2D.Impulse);
			isJumpAllowed = false;
		}
	}

	public void Die()
	{
		Debug.Log("Player::Die");
		Application.Quit ();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		isJumpAllowed = true;
	}

}
