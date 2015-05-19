using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {
	
	public Vector2 velocity 		= new Vector2(-5, 0); //Decides the obstacles scrolling speed
	public float range 				= 4;					
	float 	distanceFromCamera;
	float 	screenCrossPixelLeft;
	float 	screenCrossPixelRight;
	
	// Use this for initialization
	void Start()
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
		
		distanceFromCamera = (transform.position - Camera.main.transform.position).z;
		screenCrossPixelLeft = 1.3f * Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distanceFromCamera)).x;
		screenCrossPixelRight = 1.3f * Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distanceFromCamera)).x;

		transform.position = new Vector3(screenCrossPixelRight, 
		                                 transform.position.y - range * Random.value, 
		                                 transform.position.z);
		//Debug.Log("scrollObstacle::Update() Right: " + screenCrossPixelRight + " Left: " + screenCrossPixelLeft);
		
		InvokeRepeating("CheckLocation", 1f, 1f);
	} 
	void Update ()
	{
		
	}
	
	void CheckLocation()
	{
		if (transform.position.x < screenCrossPixelLeft) 
		{
			//Destroying this prefab obstacle
			Destroy (gameObject);
		} 
	}
	
	void ChangeSpeed(Vector2 velocity)
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
