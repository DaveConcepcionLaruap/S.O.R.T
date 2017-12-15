using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public Dialogue dialogue;

	void Start(){
		StartCoroutine (Wait ());
		StopCoroutine (Wait ());
	}

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
    }

	IEnumerator Wait(){
		yield return new WaitForSeconds (1);
		TriggerDialogue ();
	}
}
