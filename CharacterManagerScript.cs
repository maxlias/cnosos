using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManagerScript : MonoBehaviour {

    private string multiplayerMode;
    private string playerUnit;
    public Transform unityChanMultiplayer;
    public Transform minotaurMultiplayer;
    public Transform unityChan;
    public Transform minotaur;

    void Start () {

        multiplayerMode = PlayerPrefs.GetString("Multi");
        playerUnit = PlayerPrefs.GetString("Player");

        SpawnPlayers();
    }
	
	void Update () {
		
	}

    void SpawnPlayers()
    {
        var initialUnityChanPos = new Vector3(64.44f, 0.15f, 22.47f);
        var initialMinotaurPos = new Vector3(-67.44f, -0.27f, -6.51f);

        if (playerUnit == null || playerUnit == "")
        {
            PlayerPrefs.SetString("player", "unitychan");
        }

        if (multiplayerMode == null || multiplayerMode == "")
        {
            PlayerPrefs.SetString("Multi", "No");
            multiplayerMode = "No";
        }

        if (multiplayerMode == "Yes")
        {
            Debug.Log("Entro en si");
            var multiUnity = Instantiate(unityChanMultiplayer, initialUnityChanPos, transform.rotation);
            var multiMino = Instantiate(minotaurMultiplayer, initialMinotaurPos, transform.rotation);

            var tutorialController = multiUnity.Find("CharacterOnline").GetComponent(TutorialController);
        }
        else
        {
            var unity = Instantiate(unityChan, initialUnityChanPos, transform.rotation);
            var mino = Instantiate(minotaur, initialMinotaurPos, transform.rotation);
        }

    }
}
