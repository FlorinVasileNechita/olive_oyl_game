using UnityEngine;
using System.Collections;

public class ObstacleGenerator : Singleton<ObstacleGenerator> {

	protected ObstacleGenerator() {}

	public 	GameObject 	obstacle;
	public 	float 		spawnInterval;
	
	// Use this for initialization
	void Start()
	{
		InvokeRepeating("CreateObstacle", 1f, spawnInterval);
	}
	
	void CreateObstacle()
	{
		Instantiate(obstacle);
	}

}
