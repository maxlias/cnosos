using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    
    public Button start;
    public Button exit;

	// Use this for initialization
	void Start () {

        start = start.GetComponent<Button>();
        exit = exit.GetComponent<Button>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartLevel()
    {
        PlayerPrefs.SetString("Multi", "No");
        PlayerPrefs.SetString("Player", "unitychan");
        Application.LoadLevel(1);
    }

    public void StartMulitplayer(string player)
    {
        PlayerPrefs.SetString("Multi", "Yes");
        PlayerPrefs.SetString("Player", player);
        Application.LoadLevel(1);
    }

    public void QuitLevel()
    {
        Application.Quit();    
    }

    public void Restart()
    {
        Application.LoadLevel(0);
    }
}
