﻿using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

	float percent = 0.2f;
	public Vector2 speed = new Vector2(1, 1);
	
	/// <summary>
	/// Moving direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	
	private Vector2 movement;
	
	void Update()
	{
		// 1 - Movement
		movement = new Vector2(
			speed.x * direction.x * percent,
			speed.y * direction.y * percent);
	}
	
	void FixedUpdate()
	{
		// Apply movement to the rigidbody
		rigidbody2D.velocity = movement;
	}
}
