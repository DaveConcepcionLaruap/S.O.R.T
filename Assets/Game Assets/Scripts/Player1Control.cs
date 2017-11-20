using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Control : MonoBehaviour {
	public float speed = 20.0f;
	public bool idle;
	public bool FR;
	public bool FL;

	public Transform groundCheck;
	public float groundCheckRadius;
	public LayerMask whatIsGround;
	private bool grounded;
	public bool t1, t2, t3;


	private Animator anim;


	void Start () {
		FR = false;
		FL = true;
		t1 = true;
		t2 = false; 
		t3 = false;

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
		if (Input.GetKey(KeyCode.A)){
			t1 = true;
			t2 = false;
			t3 = false;
		}else if (Input.GetKey(KeyCode.S)){
			t1 = false;
			t2 = true;
			t3 = false;
		}else if(Input.GetKey(KeyCode.D)){
			t1 = false;
			t2 = false;
			t3 = true;
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
