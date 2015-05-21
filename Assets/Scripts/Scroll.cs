using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	
	public Vector2 mVelocity 		= new Vector2(-5, 0); //Decides the obstacles scrolling speed
	public float mYAxisRange 				= 4;					
	float 	mScreenCrossPixelLeft;
	float 	mScreenCrossPixelRight;
	
	// Use this for initialization
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = mVelocity;

		float 	distanceFromCamera;
		distanceFromCamera = (transform.position - Camera.main.transform.position).z;
		mScreenCrossPixelLeft = 1.3f * Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceFromCamera)).x;
		mScreenCrossPixelRight = 1.3f * Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceFromCamera)).x;

		transform.position = new Vector3(mScreenCrossPixelRight, 
		                                 transform.position.y - mYAxisRange * Random.value, 
		                                 transform.position.z);
		//Debug.Log("scrollObstacle::Update() Right: " + screenCrossPixelRight + " Left: " + screenCrossPixelLeft);
		
		InvokeRepeating("CheckLocation", 1f, 1f);
	} 
	void Update ()
	{
		
	}
	
	void CheckLocation()
	{
		if (transform.position.x < mScreenCrossPixelLeft) 
		{
			//Destroying this prefab obstacle
			Destroy (gameObject);
		} 
	}
	
	void ChangeSpeed(Vector2 velocity)
	{
		GetComponent<Rigidbody2D>().velocity = mVelocity;
	}
}
