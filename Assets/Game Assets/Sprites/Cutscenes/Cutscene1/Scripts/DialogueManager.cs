using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public Text nameText;
    public Text dText;
    public Animator animator;
    public Animator character;
    public Animator character2;
    public AudioSource audio, audio2;
    private Queue<string> sentences;

	// Use this for initialization
	void Start () {
        sentences = new Queue<string>();
	}
	
    public void StartDialogue(Dialogue dialogue)
    {
        animator.SetBool("IsOpen", true);
        character.SetBool("OpenKen", true);
        nameText.text = dialogue.name;
        sentences.Clear();

        foreach(string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        if (sentence.Equals("Omae wa mo shindeiru!"))
        {
            audio.Play();
        }
        ShowCharacter(sentence);
        SetName(sentence);
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

	IEnumerator Fade (){
		yield return new WaitForSeconds (0.8f);
		float fadeTime = GameObject.Find ("FadeBoi").GetComponent<Fading> ().BeginFade (1);
	}

    public void ShowCharacter(string sentence)
    {
        if (character2.GetBool("OpenEnemy") == false)
        {
            if (sentence.Equals("Nani?!?"))
            {
                character2.SetBool("OpenEnemy", true);
                audio2.Play();
            }
        }
        
    }

    public void SetName(string sentence)
    {
        if (sentence.Equals("Nani?!?") || sentence.Equals("Waddup, Kenshiro!"))
        {
            nameText.text = "Enemy";
            //character2.SetBool("OpenEnemy", false);
        }
        else
        {
            nameText.text = "Kenshiro";
        }
    }


    IEnumerator TypeSentence(string sentence)
    {
        dText.text = "";
        foreach(char letter in sentence.ToCharArray())
        {
            dText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        //animator.SetBool("IsOpen", false);
        //character.SetBool("OpenKen", false);
        //character2.SetBool("OpenEnemy", false);
		StopAllCoroutines();
		StartCoroutine (Fade ());
        Debug.Log("End of conversation");
    }

}
