using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public GameObject pauseButton, pausePanel, shootButton, thrownObject, player;
	//SpriteRenderer spriteRenderer;
	CoinPickUp pickup;

	void Start (){
		pickup = (CoinPickUp)player.GetComponent(typeof(CoinPickUp));
	}

	public void PauseGame(){
		Time.timeScale = 0;
		pausePanel.SetActive (true);
	}

	public void UnpauseGame(){
		Time.timeScale = 1;
		pausePanel.SetActive (false);
	}

	public void Shoot (){
		if (pickup.Load > 0) {
			Instantiate (thrownObject, new Vector3 (player.transform.localPosition.x, (player.transform.localPosition.y + 1.5f), 0), Quaternion.identity);
			pickup.Load--;
		}

		pickup.updateLoad ();
	}

}
