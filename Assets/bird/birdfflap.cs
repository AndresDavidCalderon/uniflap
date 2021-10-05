using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class birdfflap : MonoBehaviour
{
	private Rigidbody2D rig;
	public float jumpforce;
	void Start()
	{
		 rig = GetComponent<Rigidbody2D>();
}
	void Update()
	{
	   if (Input.GetButtonDown("jump"))
        {
			rig.velocity = new Vector2(0, 0);
			rig.AddForce(new Vector2(0, jumpforce));
		}
	}
}
