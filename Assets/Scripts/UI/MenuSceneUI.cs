using UnityEngine;
using System.Collections;

public class MenuSceneUI : Singleton<MenuSceneUI> {
	protected MenuSceneUI() {}

	public string mPlaySceneName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void PlayButton()
	{
		Debug.Log ("MenuSceneUI::PlayButton mPlaySceneName: " + mPlaySceneName);
		Application.LoadLevel (mPlaySceneName);
	}

	public void QuitButton()
	{
		Debug.Log ("MenuSceneUI::QuitButton");
		Application.Quit ();
	}
}
