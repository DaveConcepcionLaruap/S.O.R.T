using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.CrossPlatformInput;

public class Player1Control : MonoBehaviour {
    public float speed = 20.0f;
    public bool idle;
    public bool FR;
    public bool FL;

    public Sprite sprite1; // Drag your first sprite here
    public Sprite sprite2; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;

    public int bio, type = 0;

    public float directionX;
    Rigidbody2D rb;

    
    //throw
    private Animator anim;
    public GameObject thrownObject;
    private GameObject player;
    private CoinPickUp pickup;
    public Text counterLoad;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = sprite1; // set the sprite to sprite1

        rb = GetComponent<Rigidbody2D>();
        FR = false;
        FL = true;
        bio = 1;
        anim = GetComponent<Animator>();

        player = GameObject.Find("Aegis_Standing_0");
        pickup = (CoinPickUp)player.GetComponent(typeof(CoinPickUp));


    }


    void Update() {
        idle = true;
        movement();
        Shoot();
        anim.SetFloat("Speed", Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x));
        if (FR) {
            //transform.localRotation.x *=-1f;
			transform.localScale = new Vector2(-0.5472018f, 0.3724159f);
        } else {
            //transform.localRotation.x *=1f;
			transform.localScale = new Vector2(0.5472018f, 0.3724159f);
        }


    }

    public void Shoot()
    {
        idle = false;
		if (Input.GetKeyDown (KeyCode.V)) {
			if (pickup.Load > 0) {
				anim.SetTrigger ("Throw");
				Instantiate (thrownObject, new Vector3 (transform.localPosition.x, transform.localPosition.y, 0), Quaternion.identity);
				pickup.Load--;

				Debug.Log ("Load left: " + pickup.Load);

			} else {
				Debug.Log ("Please collect more, no more load to fire");

			}
			pickup.updateLoad ();
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
		
	public void SwitchType(){
        //confusing values
        if (type == 0) {
			spriteRenderer.color = new Color(255, 237, 0, 255);
			type = 1;
		} else if (type == 1) {
			spriteRenderer.color = new Color(255, 255, 255);
			type = 2;
		} else if (type == 2) {
			spriteRenderer.color = new Color(199, 0, 255, 255);
			type = 0;
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
