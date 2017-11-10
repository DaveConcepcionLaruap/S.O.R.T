using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoinOnGround : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D other)
	{
		if (other.GetComponent<Player1Control> () == null)
			return;

		Destroy (gameObject);
	}
}
