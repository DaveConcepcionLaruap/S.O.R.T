using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player1Control : MonoBehaviour {
	public float speed = 20.0f;
	public bool idle;
	public bool FR;
	public bool FL;

	public Sprite sprite1; // Drag your first sprite here
	public Sprite sprite2; // Drag your second sprite here

	private SpriteRenderer spriteRenderer; 

	public int bio;

	public float directionX;
	Rigidbody2D rb;

	private Animator anim;


	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
		if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
			spriteRenderer.sprite = sprite1; // set the sprite to sprite1

		rb = GetComponent<Rigidbody2D> ();
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
		 

	void movement(){

		directionX = CrossPlatformInputManager.GetAxis ("Horizontal");
		rb.velocity = new Vector2 (directionX * (speed*10), 0);

		if (directionX < 0) {
			idle = false;
			FL = true;
			FR = false;
		} else {
			idle = false;
			FL = false;
			FR = true;
		}


		if(Input.GetKeyDown (KeyCode.UpArrow)){
			ChangeSprite ();
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
		

	void ChangeSprite ()
	{
		if (spriteRenderer.sprite == sprite1) // if the spriteRenderer sprite = sprite1 then change to sprite2
		{
			spriteRenderer.sprite = sprite2;
		}
		else
		{
			spriteRenderer.sprite = sprite1; // otherwise change it back to sprite1
		}
	}

}
