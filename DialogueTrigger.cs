using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour {

    public string dialogue;
    private DialogueMana dMana;

	// Use this for initialization
	void Start () {
        dMana = FindObjectOfType<DialogueMana>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider hit)
    {
        if(hit.gameObject.name == "Character" || hit.gameObject.name == "CharacterOnline")
        {
            
            if(Input.GetKeyUp(KeyCode.E))
            {
                
                dMana.ShowBox(dialogue);
            }
        }
    }
}
