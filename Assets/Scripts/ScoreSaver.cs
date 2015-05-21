using UnityEngine;
using System.Collections;

public class ScoreSaver: Singleton<ScoreSaver> {

	protected ScoreSaver () {}
	
	public int Load()
	{
		return PlayerPrefs.GetInt("highscore");
	}

	public void Save(int score)
	{
		if( PlayerPrefs.GetInt("highscore") < score)
			PlayerPrefs.SetInt ("highscore", score);
	}
};
