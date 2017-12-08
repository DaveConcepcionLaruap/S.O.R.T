using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour {
	//public float delay;
	public GameObject coinGold;
    public GameObject residual;
    public GameObject recyclable;
	public int obj, check;
	public float x, y, z;
	public GameObject Monster;

	// Use this for initialization
	void Start () {
		StartCoroutine (Spawn ());
		StopCoroutine (Spawn ());
	}

	// Update is called once per frame


	IEnumerator Spawn() {

		while (Monster != null) {
			x = Monster.transform.position.x;
			y = Monster.transform.position.y;
			z = Monster.transform.position.z;
			obj = Random.Range (0, 3);

			if (obj == 0) {
				Instantiate (coinGold, new Vector3 (x, (y - 2), 0), Quaternion.identity);
			} else if (obj == 1) {
				Instantiate (residual, new Vector3 (x, (y - 2), 0), Quaternion.identity);
			} else if (obj == 2) {
				Instantiate (recyclable, new Vector3 (x, (y - 2), 0), Quaternion.identity);
			}
			int random = Random.Range (1, 4);
			yield return new WaitForSeconds (random);
		}

    }

}
