using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestFound : MonoBehaviour {

    
    private ItemMana iMana;
    public DialogueMana dMana;

    // Use this for initialization
    void Start()
    {
        iMana = FindObjectOfType<ItemMana>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerStay(Collider hit)
    {
        if (hit.gameObject.name == "Character")
        {

            if (Input.GetKeyUp(KeyCode.E))
            {

                var chest = hit.gameObject.GetComponent<VariableChest>().getKeyNumber();
                var thisChest = int.Parse(this.gameObject.name);

                if (thisChest == chest)
                {
                    dMana.ShowBox("You found the key! Hurry and escape");
                    iMana.ShowItem();
                }
                else
                {
                    dMana.ShowBox("Empty chest");
                }

            }
               
        }
    }
}
