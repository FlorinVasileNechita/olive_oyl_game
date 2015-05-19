using UnityEngine;
using System.Collections;

public class CoinKeeper : Singleton<CoinKeeper> {

	protected CoinKeeper() {}

	
	public int spawnPowerUpCount;
	public int coinsCollected;
	// Use this for initialization
	void Awake () {
		coinsCollected = 0;
	}

	public void CoinCollected()
	{
		coinsCollected++;
		Debug.Log ("CoinKeeper::CoinCollected coins = " + coinsCollected);

		if (coinsCollected % spawnPowerUpCount == 0)
			GameController.Instance.SpawnPowerUp ();

	}
}
