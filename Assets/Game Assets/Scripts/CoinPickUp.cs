using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

	public int hit = 0 ;

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player1Control> () == null)
			return;

		hit += 1;
		Destroy (gameObject);
	}

}
