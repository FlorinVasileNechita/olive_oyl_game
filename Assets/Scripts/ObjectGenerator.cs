using UnityEngine;
using System.Collections;

public class ObjectGenerator : Singleton<ObjectGenerator> {
	
	protected ObjectGenerator() {}
	
	public 	GameObject 	mObj;
	public 	float 		mSpawnInterval;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObject", 1f, mSpawnInterval);
	}
	
	void CreateObject()
	{
		Instantiate(mObj);
	}
	
}
