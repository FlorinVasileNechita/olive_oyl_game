using UnityEngine;
using System.Collections;

public class TouchController : Singleton<TouchController> {

	protected TouchController () {}

	GameController sGameController;

	public string mMenuSceneName;

	void Start()
	{
		sGameController = GameController.Instance;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			Application.LoadLevel(mMenuSceneName);
		}
		
		if(Input.GetMouseButtonDown(0) ||
		   (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)) 
		{
			//ScreenTouched();
		}
	}

    public void JumpButtonPressed()
    {
        sGameController.JumpButtonPressed();
    }

    public void DownButtonPressed()
    {
        sGameController.DownButtonPressed();
    }
}
