using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

	public int score = 0;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Gold"){
            score++;
            Destroy(other.gameObject);
            Debug.Log("Coin picked up, Score = " + score);
        }else if (other.gameObject.tag == "Recyclable"){
            score++;
            Destroy(other.gameObject);
            Debug.Log("Recyclable picked up, Score = " + score);
        }else if (other.gameObject.tag == "Residual"){
            score++;
            Destroy(other.gameObject);
            Debug.Log("Residual picked up, Score = " + score);
        }


    }

}
