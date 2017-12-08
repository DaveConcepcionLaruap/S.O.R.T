using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	int count = 0;
	public GameObject mons;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 4) {
			Destroy (mons);
		}
	}

	void OnTriggerEnter2D(Collider2D Col){

		if (Col.gameObject.tag == "Power") {
			count++;
		}

	}
}
