using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
public class Movement : MonoBehaviour {
	[SerializeField]Transform Target;
	[SerializeField]direction dir;
	public float speed = 20.0f;
	void OnMouseDown()
	{
		switch (dir) {
		case direction.left:
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
			break;
		case direction.right:
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
			break;
		}
	}

	public enum direction
	{
		left,
		right
	}
}
