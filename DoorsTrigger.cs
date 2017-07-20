using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsTrigger : MonoBehaviour {

    private ItemMana iMana;
    // Use this for initialization
    void Start () {

        iMana = FindObjectOfType<ItemMana>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay(Collider hit)
    {
        var keyFound = iMana.GetKeyState();
        if (hit.gameObject.name == "Character" && keyFound)
        {
            Application.LoadLevel(3);
        }
    }
}
