using UnityEngine;
using System.Collections;

public class ObjectGenerator : Singleton<ObjectGenerator> {
	
	protected ObjectGenerator() {}
	
	public 	GameObject 	obj;
	public 	float 		spawnInterval;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObject", 1f, spawnInterval);
	}
	
	void CreateObject()
	{
		Instantiate(obj);
	}
	
}
