using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour {
	public float delay = 0.5f; 
	public GameObject coinGold;
    public GameObject residual;
    public GameObject recyclable;
    public int obj;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", delay, delay);  
	}
	
	// Update is called once per frame
	void Spawn() {
        
        obj = Random.Range(0, 3);

        if (obj == 0){
            Instantiate(coinGold, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
        }else if (obj == 1){
            Instantiate(residual, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
        }else if (obj == 2){
            Instantiate(recyclable, new Vector3(Random.Range(-6, 6), 10, 0), Quaternion.identity);
        }

    }

}
