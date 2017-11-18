using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {
	public float delay = 0.5f; 
	public GameObject coinGold;
    public int hit;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay);  
	}
	
	// Update is called once per frame
	void Spawn() {
		Instantiate (coinGold, new Vector3 (Random.Range (-6, 6), 10, 0), Quaternion.identity);
	}

}
