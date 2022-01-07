using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class birdfflap : MonoBehaviour
{
	Rigidbody2D rig;
	public float jumpforce;
	SpriteRenderer spr;
	public Sprite flapped;
	Sprite normal;
	void Start()
	{
		spr = (SpriteRenderer)GetComponent("SpriteRenderer");
		rig = (Rigidbody2D) GetComponent("Rigidbody2D");
		normal = spr.sprite;
	}
	void Update()
	{
	   if (Input.GetButtonDown("jump"))
        {
			rig.velocity = new Vector2(0, 0);
			rig.AddForce(new Vector2(0, jumpforce));
			spr.sprite =  flapped;
		}
	   if (Input.GetButtonUp("jump"))
        {
			spr.sprite = normal;
        }
	}
}
