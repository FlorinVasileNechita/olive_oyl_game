using UnityEngine;
using System.Collections;

public class UIController : Singleton<UIController> {

	GameController sGameController;
	UICoinsDisplay sUICoinsDisplay;
	UIScoreDisplay sUIScoreDisplay;
	UIHeartDisplay sUIHeartDisplay;

	// Use this for initialization
	void Awake () {
		sGameController = GameController.Instance;
		sUICoinsDisplay = UICoinsDisplay.Instance;
		sUIScoreDisplay = UIScoreDisplay.Instance;
		sUIHeartDisplay = UIHeartDisplay.Instance;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int getCoinsCollected()
	{
		return sGameController.getCoinsCollected ();
	}

	public void CoinCollected(int coins)
	{
		sUICoinsDisplay.UpdateDisplay (coins);
	}

	public void ScoreChanged(int score)
	{
		sUIScoreDisplay.UpdateDisplay (score);
	}

	public void LivesChanged(int lives)
	{
		sUIHeartDisplay.UpdateDisplay (lives);
	}
}
