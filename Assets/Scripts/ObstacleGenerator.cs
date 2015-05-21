using UnityEngine;
using System.Collections;

public class ObstacleGenerator : Singleton<ObstacleGenerator> {

	protected ObstacleGenerator() {}

	public 	GameObject 	mObstacle;
	public 	float 		mSpawnInterval;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, mSpawnInterval);
	}
	
	void CreateObstacle()
	{
		Instantiate(mObstacle);
	}

}
