using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseFunctions : MonoBehaviour {

	public Image volume;
	public AudioSource audio;

	public void DecreaseVol(){
		volume.fillAmount -= 0.2f;
		audio.volume -= 0.2f;
	}

	public void IncreaseVol(){
		volume.fillAmount += 0.2f;
		audio.volume += 0.2f;
	}
}
