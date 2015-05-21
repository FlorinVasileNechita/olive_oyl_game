using UnityEngine;
using System.Collections;

public class LifeKeeper : Singleton<LifeKeeper> {

	int mLivesLeft = 3;

	public void LifeLost()
	{
		mLivesLeft--;
		Debug.Log ("LifeKeeper::LifeLost() livesLeft = " + mLivesLeft);
	}

	public void LifeGained()
	{
		if (mLivesLeft >= 3)
			return;
		mLivesLeft++;
		Debug.Log ("LifeKeeper::LifeGained() livesLeft = " + mLivesLeft);
	}

	public bool isLifeLeft()
	{
		if (mLivesLeft != 0)
			return true;
		return false;
	}

	public int getLivesLeft()
	{
		return mLivesLeft;
	}
}
