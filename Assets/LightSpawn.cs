using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSpawn : MonoBehaviour 
{
	public GameObject lighteffect;
	public float spawnRate = 2;
	private float timer = 0;

	// Use this for initialization
	void Start () 
	{
		spawnLight();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (timer < spawnRate)
		{
			timer += Time.deltaTime;
		}
		else
		{
			spawnLight();
			timer = 0;
		}
		
	}
	void spawnLight()
	{
		Instantiate(lighteffect, transform.position, transform.rotation);
	}
}

