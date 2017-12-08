using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fall : MonoBehaviour {
	public float delay;
	public GameObject coinGold;
    public GameObject residual;
    public GameObject recyclable;
	public int obj;
	public float x, y, z;
	public GameObject Monster;

	// Use this for initialization
	void Start () {
		while (true) {
			StopAllCoroutines ();
			StartCoroutine (Wait ());
			Spawn ();
		}

	}

	// Update is called once per frame
	IEnumerator Wait(){
		yield return new WaitForSeconds (Random.Range (1.0f, 5.0f));
	}

	void Spawn() {
		x = Monster.transform.position.x;
		y = Monster.transform.position.y;
		z = Monster.transform.position.z;
        obj = Random.Range(0, 3);

		delay = Random.Range (0.5f,7.5f);
        if (obj == 0){
			Instantiate(coinGold, new Vector3(x, y, 0), Quaternion.identity);
        }else if (obj == 1){
			Instantiate(residual, new Vector3(x, y, 0), Quaternion.identity);
        }else if (obj == 2){
			Instantiate(recyclable, new Vector3(x, y, 0), Quaternion.identity);
        }

    }

}
