using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class ButtonMovement : MonoBehaviour {

	public float speed = 20.0f;
	public bool idle;
	public bool FR;
	public bool FL;
	public int bio, type = 0;
	public float directionX;
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		FR = false;
		FL = true;
		bio = 1;
	}
	
	// Update is called once per frame
	void Update () {
		idle = true;
		if (FR) {
			//transform.localRotation.x *=-1f;
			transform.localScale = new Vector2(-0.5472018f, 0.3724159f);
		} else {
			//transform.localRotation.x *=1f;
			transform.localScale = new Vector2(0.5472018f, 0.3724159f);
		}
	}

	public void MoveLeft(){
		idle = false;
		FL = true;
		FR = false;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
	}

	public void MoveRight(){
		idle = false;
		FL = false;
		FR = true;
		GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
	}
}
