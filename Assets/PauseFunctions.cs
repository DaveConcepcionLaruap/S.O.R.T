using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseFunctions : MonoBehaviour {

	public Image BGMBar, SFXBar;
	public AudioSource BGM, SFX, shootSFX;

	//BGM
	public void DecreaseBGMVol(){
		BGMBar.fillAmount -= 0.2f;
		BGM.volume -= 0.2f;
	}

	public void IncreaseBGMVol(){
		BGMBar.fillAmount += 0.2f;
		BGM.volume += 0.2f;
	}

	//SFX
	public void DecreaseSFXVol(){
		SFXBar.fillAmount -= 0.2f;
		SFX.volume -= 0.2f;
		shootSFX.volume -= 0.2f;
	}

	public void IncreaseSFXVol(){
		SFXBar.fillAmount += 0.2f;
		SFX.volume += 0.2f;
		shootSFX.volume += 0.2f;
	}

	//Replay
	public void ReplayButton(){
		Time.timeScale = 1;
		SceneManager.LoadScene (7);
	}
}
