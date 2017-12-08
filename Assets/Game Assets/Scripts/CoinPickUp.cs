using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {


    private int score;
    private int load;

    public int Score
    {
        get
        {
            return score;
        }

        set
        {
            score = value;
        }
    }

    public int Load
    {
        get
        {
            return load;
        }

        set
        {
            load = value;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Gold"){
            Score++;
            Load++;
            Destroy(other.gameObject);
            Debug.Log("Coin picked up, Score = " + Score);
        }else if (other.gameObject.tag == "Recyclable"){
            Score++;
            Load++;
            Destroy(other.gameObject);
            Debug.Log("Recyclable picked up, Score = " + Score);
        }else if (other.gameObject.tag == "Residual"){
            Score++;
            Load++;
            Destroy(other.gameObject);
            Debug.Log("Residual picked up, Score = " + Score);
        }


    }

}
