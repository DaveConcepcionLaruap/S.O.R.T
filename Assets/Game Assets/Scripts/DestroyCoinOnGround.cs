using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCoinOnGround : MonoBehaviour {

    public GameObject coin;

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Goodbye");
        if (other.gameObject.tag == "Gold")
        {
            Destroy(other.gameObject);
        }
    }




}
