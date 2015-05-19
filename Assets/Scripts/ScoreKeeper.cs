using UnityEngine;
using System.Collections;

public class ScoreKeeper: Singleton<ScoreKeeper> {

	protected ScoreKeeper () {}

	public static int score;

	/// <summary>
	/// Resets the score
	/// </summary>
	public void StartGame()
	{
		score = 0;
	}
	
	void Awake()
	{
		//Toolbox.RegisterComponent<ScoreKeeper> ();
	}

	/// <summary>
	/// Save the score on end of game
	/// </summary>
	public void EndGame()
	{
		ScoreSaver.Instance.Save(score);
	}

	/// <summary>
	/// Adds the score.
	/// </summary>
	/// <param name="del">Delta</param>
	public void AddScore(int del)
	{
		score = score + del;
		NotifyScoreChanged (score);
		Debug.Log("Score is " + score + "!");
	}

	/// <summary>
	/// Notifies the score changed.
	/// </summary>
	/// <param name="score">Score.</param>
	public void NotifyScoreChanged(int score)
	{
		GameController.Instance.ScoreChanged (score);
	}
}
