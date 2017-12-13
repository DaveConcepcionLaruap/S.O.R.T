using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour {

	public GameObject pauseButton, pausePanel, victoryPanel, shootButton, thrownObject, player, monster;
	public GameObject monsterPrefab;
	public int monsterCount;
	public Animator anim;
	//SpriteRenderer spriteRenderer;
	CoinPickUp pickup;
	Life life;


	void Start (){
		pickup = (CoinPickUp)player.GetComponent(typeof(CoinPickUp));
		life = (Life)monster.GetComponent (typeof(Life));
	}

	void Update(){
		if (anim.GetCurrentAnimatorStateInfo (0).IsName ("Flash Out")) {
			if (GameObject.FindGameObjectsWithTag ("Monster").Length == 1) {
				int no = Random.Range (1, 5);
				if (monsterCount - no < 0) {
					while (monsterCount - no < 0) {
						no--;
					}
				}
				if (monsterCount == 0) {
					Victory ();
				} else {
					for (int i = 1; i <= no; i++) {
						monster = Instantiate (monsterPrefab, new Vector3 (Random.Range (-15, 8), 5.53f, 9.992758f), Quaternion.identity);
					}
				}
				monsterCount -= no;
			}
		}
	}

	IEnumerator Wait(){
		yield return new WaitForSeconds (3);
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

	public void Victory(){
		victoryPanel.SetActive (true);
		Time.timeScale = 0;
	}


}
