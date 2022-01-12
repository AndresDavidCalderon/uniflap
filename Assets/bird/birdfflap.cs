using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class birdfflap : MonoBehaviour
{
	Rigidbody2D rig;
	public float jumpforce;
	SpriteRenderer spr;
	public Sprite flapped;
	public float minspeed;
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
		else
        {
			if (rig.velocity.y < minspeed && rig.velocity.y > 0)
			{
				rig.velocity = new Vector2(0, 0);
			}
		}
		if (Input.GetButtonUp("jump"))
        {
			spr.sprite = normal;
        }
	}
	public void Lose()
	{
		transform.position = new Vector2(transform.position.x, Camera.main.ViewportToWorldPoint(new Vector2(0, 0.5f)).y);
		foreach (Transform child in GameObject.Find("obstacles").GetComponent<Transform>())
		{
			Destroy(child.gameObject);
        }
		GameObject.Find("Main Camera/Canvas/score").GetComponent<Text>().text="0";
	}
}
