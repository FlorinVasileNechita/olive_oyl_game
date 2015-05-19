using UnityEngine;
using System.Collections;

public class UIController : Singleton<UIController> {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getCoinsCollected()
	{
		return GameController.Instance.getCoinsCollected ();
	}

	public void CoinCollected(int coins)
	{
		UICoinsDisplay.Instance.UpdateDisplay (coins);
	}

	public void ScoreChanged(int score)
	{
		UIScoreDisplay.Instance.UpdateDisplay (score);
	}
}
