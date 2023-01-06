using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightEffectScroll : MonoBehaviour 
{
	public float movespeed = 5;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		transform.position = transform.position + (Vector3.right * movespeed) * Time.deltaTime;
		
		if (transform.position.x == 100)
		{
			destroyLight();
		}
	}

	void destroyLight()
	{
		Destroy(gameObject);
	}
}
