using UnityEngine;
using System.Collections;

public class CoinKeeper : Singleton<CoinKeeper> {

	protected CoinKeeper() {}

	GameController sGameController;
	
	public int mSpawnPowerUpCount;
	int mCoinsCollected;
	// Use this for initialization
	void Awake () {
		sGameController = GameController.Instance;
		mCoinsCollected = 0;
	}

	public void CoinCollected()
	{
		mCoinsCollected++;
		Debug.Log ("CoinKeeper::CoinCollected coins = " + mCoinsCollected);

		if (mCoinsCollected % mSpawnPowerUpCount == 0)
			sGameController.SpawnPowerUp ();

	}

	public int getCoinsCollected()
	{
		return mCoinsCollected;
	}
}
