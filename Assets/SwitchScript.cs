using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchScript : MonoBehaviour 
{
	public bool isOff = true;
	public GameObject PairedObject;
	public string selectScript;
	public Animator animator;
	public BoxCollider2D boxCollider;
	private Vector2 defaultColliderOffset;
	public float colliderXOffset, colliderYOffset;


	// Use this for initialization
	void Start () 
	{
		defaultColliderOffset = boxCollider.offset;
	}
	
	// Update is called once per frame
	void Update () 
	{
		DoorScript script = PairedObject.GetComponent(selectScript) as DoorScript;
		
		if (isOff == false)
		{
			script.isClosed = false;
			animator.SetBool("isOff", false);
			boxCollider.offset = new Vector2(colliderXOffset, colliderYOffset);

		}else
		{
			script.isClosed = true;
			animator.SetBool("isOff", true);
			boxCollider.offset = new Vector2(defaultColliderOffset.x, defaultColliderOffset.y);

		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			isOff = !isOff;
		}
	}
}
