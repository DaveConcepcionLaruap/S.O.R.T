using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player1Control : MonoBehaviour {
	public float speed = 20.0f;
	public bool idle;
	public bool FR;
	public bool FL;

	public int bio;

	public float directionX;
	Rigidbody2D rb;

	private Animator anim;


	void Start () {
		FR = false;
		FL = true;
		bio = 1; 
		anim = GetComponent<Animator> ();
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
		 
	public void movement(){

		directionX = CrossPlatformInputManager.GetAxis ("Horizontal");
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (directionX * speed, GetComponent<Rigidbody2D> ().velocity.y);


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
