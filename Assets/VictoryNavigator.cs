using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryNavigator : MonoBehaviour {

	public void  BackToMenu(){
		SceneManager.LoadScene (2);
	}
}
