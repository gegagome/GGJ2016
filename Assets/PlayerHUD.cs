using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.ThirdPerson;

using UnityEngine.UI;

public class PlayerHUD : GGJBehaviour {

	public ThirdPersonCharacter playerCharacter;

	public Text scoreLabel;
	public Text LivesLabel;
	public Text HealthLabel;

	// Update is called once per frame
	void Update () {
		if (playerCharacter) {
			scoreLabel.text = "Score: " + GameManager.score.ToString ("#");;
			LivesLabel.text = "3";
			HealthLabel.text = "Health: " + playerCharacter.health;
		}
	}
}
