using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	public int count = 0;
	public GameObject mons;
    SpriteRenderer spriteRenderer;
    // Use this for initialization
    void Start () {
        spriteRenderer = (SpriteRenderer) mons.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
		if (count == 4) {
			Destroy (mons);
		}

        spriteRenderer = (SpriteRenderer)mons.GetComponent<Renderer>();
    }

	void OnTriggerEnter2D(Collider2D Col)
    {
        
		if (Col.gameObject.tag == "Power") {
			count++;
		}


        UpdateMonsterColor();
	}

    void UpdateMonsterColor()
    {
        switch (count)
        {
            case 1:
                spriteRenderer.color = new Color(0, 1, 0, 1);
                break;
            case 2:
                spriteRenderer.color = new Color(255, 255, 0, 1);
                break;
            case 3:
                spriteRenderer.color = new Color(255, 0, 0, 1);
                break;
        }

    }
}
