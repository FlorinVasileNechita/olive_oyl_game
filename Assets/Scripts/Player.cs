using UnityEngine;
using System.Collections;

public class Player : Singleton<Player> {

	protected Player () {}
	public Vector2 mTouchForce = new Vector2(0f, 2f);
	private bool mIsJumpAllowed = true;

	void Update()
	{
		float 	distanceFromCamera, centerPositionX;
		distanceFromCamera = (transform.position - Camera.main.transform.position).z;
		centerPositionX = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, distanceFromCamera)).x;

		
		transform.position = new Vector3(centerPositionX, 
		                                 transform.position.y,
		                                 transform.position.z);
	}

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

    public void ComeDown()
    {
        if (!mIsJumpAllowed)
        {
            Rigidbody2D rigidBody = Player.Instance.GetComponent<Rigidbody2D>();
            rigidBody.velocity = Vector2.zero;
            rigidBody.AddForce(-1.0f * mTouchForce, ForceMode2D.Impulse);
            mIsJumpAllowed = false;
        }
    }

	public void Die()
	{
		Debug.Log("Player::Die");
	}

	void OnCollisionEnter2D(Collision2D collision)
	{
		mIsJumpAllowed = true;
	}

}
