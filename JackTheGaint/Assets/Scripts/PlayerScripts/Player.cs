using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 8.0f;
	public float maxVelocity = 4.0f;
	private Rigidbody2D myBody;
	private Animator anim;
	// Use this for initialization
	void Start () {
		myBody = GetComponent<Rigidbody2D>();
		anim = GetComponent<Animator>();
	}
	
	void FixedUpdate () {
		PlayerMovement();
		
 	}

	void PlayerMovement(){
		float forceX = 0f;
		float vel = Mathf.Abs(myBody.velocity.x);

		float h = Input.GetAxisRaw("Horizontal");

		if (h > 0){

			if (vel < maxVelocity){
				forceX = speed;
			}
				
			anim.SetBool("walk", true);
			Vector3 scale = transform.localScale;
			scale.x = 1;
			transform.localScale = scale;

		}else if(h < 0){

			if (vel < maxVelocity){
				forceX = -speed;
			}

			anim.SetBool("walk", true);
			Vector3 scale = transform.localScale;
			scale.x = -1;
			transform.localScale = scale;	
		
		}
		else
		{
			anim.SetBool("walk", false);
		}
		myBody.AddForce(new Vector2(forceX, 0));

	}

}
