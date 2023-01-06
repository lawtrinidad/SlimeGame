using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour 
{
	public bool isClosed = true;
	public float moveSpeed = 5;
	public Vector3 openPosition;
	private Vector3 defaultPosition;

	// Use this for initialization
	void Start () 
	{
		defaultPosition = transform.position;
		Debug.Log("Door is ready");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if ((isClosed == false) && (transform.position.x < openPosition.x))
		{
			transform.position = transform.position + (Vector3.right * moveSpeed) * Time.deltaTime;
		}
		else if ((isClosed == true) && (transform.position.x > defaultPosition.x))
		{
			transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
		}
	}
}
