using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemMana : MonoBehaviour {

    
    public Image iImage;
    private bool keyFound = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ShowItem()
    {
        iImage.gameObject.SetActive(true);
        keyFound = true;
    }

    public bool GetKeyState()
    {
        if(keyFound)
        {
            return true;
        }

        return false;
    }
}
