using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	
	public Vector2 mVelocity; //Decides the obstacles scrolling speed
	public float mYAxisRange 				= 4;					
	float 	mScreenCrossPixelLeft;
	float 	mScreenCrossPixelRight;
	float 	mSpriteCompensation;
	
	// Use this for initialization
	void Start()
	{
		if(mVelocity.x != 0) 
			GetComponent<Rigidbody2D>().velocity = mVelocity;

		float 	distanceFromCamera;
		distanceFromCamera = (transform.position - Camera.main.transform.position).z;
		mScreenCrossPixelLeft = /*1.3f * */Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceFromCamera)).x;
		mScreenCrossPixelRight = /*1.3f * */Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceFromCamera)).x;

		Renderer renderer = GetComponent<Renderer> ();
		if (renderer != null)
			mSpriteCompensation = renderer.bounds.size.x / 2;

		transform.position = new Vector3(mScreenCrossPixelRight + mSpriteCompensation, 
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
		if (transform.position.x < mScreenCrossPixelLeft - mSpriteCompensation) 
		{
			//Destroying this prefab obstacle
			Destroy (gameObject);
		} 
	}
}
