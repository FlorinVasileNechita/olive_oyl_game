using UnityEngine;
using System.Collections;

public class LifeKeeper : Singleton<LifeKeeper> {

	int livesLeft = 3;

	public void LifeLost()
	{
		livesLeft--;
		Debug.Log ("LifeKeeper::LifeLost() livesLeft = " + livesLeft);
	}

	public void LifeGained()
	{
		if (livesLeft >= 3)
			return;
		livesLeft++;
		Debug.Log ("LifeKeeper::LifeGained() livesLeft = " + livesLeft);
	}

	public bool isLifeLeft()
	{
		if (livesLeft != 0)
			return true;
		return false;
	}
}
