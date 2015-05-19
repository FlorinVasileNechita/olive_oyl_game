using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UICoinsDisplay : Singleton<UICoinsDisplay> {

	public void UpdateDisplay(int coins)
	{
		Text guiText = UICoinsDisplay.Instance.GetComponent<Text> ();
		if (!guiText) 
		{
			Debug.LogError("UIScoreDisplay::UpdateDisplay guiText is NULL");
			return;
		}
		guiText.text = coins.ToString();
	}
}
