using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
	private Vector3 MovingDirection = Vector3.left;    //initial movement direction

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {    
		UpdateMovement ();
	}

	void UpdateMovement(){
		
		if (this.transform.position.x > 10f) {
			MovingDirection = Vector3.left;
			gameObject.GetComponent<SpriteRenderer> ().flipX = false;


		} else if (this.transform.position.x < -15f) { 
			MovingDirection = Vector3.right;
			gameObject.GetComponent<SpriteRenderer> ().flipX = true;

		} 
		this.transform.Translate ((MovingDirection*5) * Time.smoothDeltaTime);
	}
}