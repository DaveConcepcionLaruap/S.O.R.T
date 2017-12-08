using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power : MonoBehaviour {

    public float powerSpeed;

    private Rigidbody2D rB;


	// Use this for initialization
	void Start () {
        rB = GetComponent<Rigidbody2D>();
        


	}
	
	// Update is called once per frame
	void Update () {
        rB.velocity = new Vector2(0f, powerSpeed);

	}


    void OnTriggerEnter2D(Collider2D other)
    {

		if (other.gameObject.tag == "Border") {
			Debug.Log ("Power destroyed");
			Destroy (gameObject);
		} else if (other.gameObject.tag == "Monster") {
			Destroy (gameObject);
		}
    }
}
