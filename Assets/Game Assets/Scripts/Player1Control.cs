using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Control : MonoBehaviour {
	public float speed = 20.0f;
	public bool idle;
	public bool FR;
	public bool FL;

	public int bio;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;


	private Animator anim;


	void Start () {
		FR = false;
		FL = true;
		bio = 1; 
		anim = GetComponent<Animator> ();
	}


	void FixedUpdate() {
		grounded = Physics2D.OverlapCircle (groundCheck.position, groundCheckRadius, whatIsGround);
	}
		
	void Update () {
		idle = true;
		movement ();
		anim.SetFloat ("Speed", Mathf.Abs(GetComponent<Rigidbody2D> ().velocity.x));
		if (FR) {
			//transform.localRotation.x *=-1f;
			transform.localScale = new Vector2 (-0.6237f, 0.4803f);
		} else {
			//transform.localRotation.x *=1f;
			transform.localScale = new Vector2 (0.6237f, 0.4803f);
		}


	}
		 

	void movement(){

		/*if (Input.GetKey(KeyCode.UpArrow) && grounded){
			jump();
		}
		*/
		if (Input.GetKey(KeyCode.Space)){
			bio *= -1;
		}


		if (Input.GetKey(KeyCode.RightArrow)){
			idle = false;
			FR = true;
			FL = false;
			//transform.position += Vector3.right * speed * Time.deltaTime;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKey(KeyCode.LeftArrow)){
			idle = false;
			FL = true;
			FR = false;
			//transform.position += Vector3.left * speed * Time.deltaTime;
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
		}
			
	
	}


}
