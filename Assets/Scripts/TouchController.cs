using UnityEngine;
using System.Collections;

public class TouchController : Singleton<TouchController> {

	protected TouchController () {}

	// Use this for initialization
	void Start () {

	}

	void Awake()
	{
		//Toolbox.RegisterComponent<TouchController> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			//Application.LoadLevel("StartMenu");
		}
		
		if(Input.GetMouseButtonDown(0) ||
		   (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)) 
		{
			ScreenTouched();
		}
	}

	void ScreenTouched()
	{
		GameController.Instance.Jump ();
	}
}
