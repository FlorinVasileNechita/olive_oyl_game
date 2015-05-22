using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIHeartDisplay : Singleton<UIHeartDisplay> {

	public void UpdateDisplay(int score)
	{
		Text guiText = UIHeartDisplay.Instance.GetComponent<Text> ();
		if (!guiText) 
		{
			Debug.LogError("UIHeartDisplay::UpdateDisplay guiText is NULL");
			return;
		}
		guiText.text = score.ToString();
	}
}
