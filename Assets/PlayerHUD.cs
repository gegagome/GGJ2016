using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

using UnityEngine.UI;

public class PlayerHUD : GGJBehaviour {

	public OmariTest playerCharacter;

	public Text scoreLabel;
	//public Text LivesLabel;
	public Text HealthLabel;
    public Text TimeLabel;
    private float timeLeft;
    public SpawnSystem spawnReference;
    void Start ()
    {

        //Debug.Log("SpawnLength: " + SpawnSystem.levelReference.LevelLengthInTime);
    }

	// Update is called once per frame
	void Update () {
		if (playerCharacter) {
			scoreLabel.text = "Coins: " + GameManager.score.ToString ("#");
            timeLeft = SpawnSystem.levelReference.LevelLengthInTime+4f;

            //LivesLabel.text = "3";
            HealthLabel.text = "Health: " + playerCharacter.health + "/4";
            timeLeft -= Time.timeSinceLevelLoad;
            TimeLabel.text = "Time to Goal: " + (int)timeLeft;
		}
	}
}
