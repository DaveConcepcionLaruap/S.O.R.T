using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoinOnGround : MonoBehaviour {


    void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Gold"){
            //Debug.Log("Gold destroyed");
            Destroy(other.gameObject);
        }else if (other.gameObject.tag == "Recyclable"){
            //Debug.Log("Recyclable destroyed");
            Destroy(other.gameObject);
        }else if (other.gameObject.tag == "Residual"){
            //Debug.Log("Recyclable destroyed");
            Destroy(other.gameObject);
        }
    }




}
