using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

	public int hit = 0 ;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            hit ++;
            Destroy(gameObject);
            Debug.Log("HIT = " + hit);
        }


    }

}
