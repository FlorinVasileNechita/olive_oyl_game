using UnityEngine;
using System.Collections;

public class GameController : Singleton<GameController> {

	protected GameController () {}
	
	// Use this for initialization
	void Start () {
	
	}

	
	void Awake()
	{
		//Toolbox.RegisterComponent<GameController> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Jump()
	{
		Player.Instance.Jump ();
	}

	public void Die()
	{
		Debug.Log("GameController::Die()");
		LifeKeeper.Instance.LifeLost ();
		if (!LifeKeeper.Instance.isLifeLeft ())
			GameOver ();
	}

	public void GameOver()
	{
		Debug.Log("GameController::GameOver()");
		Player.Instance.Die ();
	}

	public void CoinCollected()
	{
		CoinKeeper.Instance.CoinCollected ();
		UIController.Instance.CoinCollected (CoinKeeper.Instance.coinsCollected);
	}

	public int getCoinsCollected()
	{
		return CoinKeeper.Instance.coinsCollected;
	}

	public void ScoreChanged(int score)
	{
		UIController.Instance.ScoreChanged (score);
	}

	public void HeartCollected()
	{
		LifeKeeper.Instance.LifeGained ();
	}

	public void SpawnPowerUp ()
	{
		HeartGenerator.Instance.SpawnObject ();
	}
}
