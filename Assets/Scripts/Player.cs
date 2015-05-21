using UnityEngine;
using System.Collections;

public class Player : Singleton<Player> {

	protected Player () {}
	public Vector2 mTouchForce = new Vector2(0f, 2f);
	private bool mIsJumpAllowed = true;

	public void Jump()
	{
		//Debug.Log("Player::Jump");
		if (mIsJumpAllowed) 
		{
			Rigidbody2D rigidBody = Player.Instance.GetComponent<Rigidbody2D> ();
			rigidBody.velocity = Vector2.zero;
			rigidBody.AddForce (mTouchForce, ForceMode2D.Impulse);
			mIsJumpAllowed = false;
		}
	}

	public void Die()
	{
		Debug.Log("Player::Die");
		Application.Quit ();
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		mIsJumpAllowed = true;
	}

}
