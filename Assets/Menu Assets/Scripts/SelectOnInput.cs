using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectOnInput : MonoBehaviour {


	public EventSystem eventSystem;
	public GameObject selectedObject;

	private bool btnSelected = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxisRaw ("Vertical") != 0 && btnSelected == false) {
			eventSystem.SetSelectedGameObject (selectedObject);
			btnSelected = true;
		}
	}

	private void OnDisable()
	{
		btnSelected = false;
	}

}
