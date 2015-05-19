using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIScoreDisplay : Singleton<UIScoreDisplay> {
	
	public void UpdateDisplay(int score)
	{
		Text guiText = UIScoreDisplay.Instance.GetComponent<Text> ();
		if (!guiText) 
		{
			Debug.LogError("UIScoreDisplay::UpdateDisplay guiText is NULL");
			return;
		}
		guiText.text = score.ToString();
	}
}
