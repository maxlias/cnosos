using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableChest : MonoBehaviour {

    private int chestWithKey;
	// Use this for initialization
	void Start () {

        chestWithKey = Random.Range(1, 8);
        Debug.Log(chestWithKey);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getKeyNumber()
    {
        return chestWithKey;
    }
}
