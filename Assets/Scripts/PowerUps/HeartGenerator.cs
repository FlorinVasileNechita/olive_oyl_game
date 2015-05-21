using UnityEngine;
using System.Collections;

public class HeartGenerator : Singleton<HeartGenerator> {
	
	protected HeartGenerator() {}
	
	public 	GameObject 	mObj;

	public void SpawnObject()
	{
		Debug.Log("HeartGenerator::SpawnObject()");
		Instantiate(mObj);
	}
}
