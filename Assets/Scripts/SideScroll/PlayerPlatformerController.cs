﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPlatformerController : PhysicsObject {

	public float maxSpeed = 7;
	public float jumpTakeOffSpeed = 7;
	private SpriteRenderer spriteRenderer;

	void OnTriggerStay2D( Collider2D col) {
		if (col.gameObject.tag == "PlayerInteract") {
			col.gameObject.GetComponent<ObjectBehavior> ().interactWithPlayer (this.gameObject);

		}
	}


	protected override void ComputeVelocity()
	{
		Vector2 move = Vector2.zero;

		move.x = Input.GetAxis ("Horizontal");

		if (Input.GetButtonDown ("Jump") && grounded) {
			velocity.y = jumpTakeOffSpeed;
		} else if (Input.GetButtonUp ("Jump")) 
		{
			if (velocity.y > 0) {
				velocity.y = velocity.y * 0.5f;
			}
		}

	

		targetVelocity = move * maxSpeed;
	}
}
