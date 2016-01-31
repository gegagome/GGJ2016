using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuBehavior : MonoBehaviour {

	bool isDead;
	const string TITLE_DEATH = "you suck";
	const string TITLE_START = "Welcome";
	const string TITLE_MAIN_MENU = "Main menu";
	const string BUTTON_DIE_AGAIN = "Die again";
	const string BUTTON_DIE = "Die";
	const string BUTTON_CREDITS = "Credits";

	public Text title;
	public Button topButton;
	public Button lowerButton;

	void Start () {
//		isDead = true;
		if (!isDead) {
			title.text = TITLE_START;
			topButton.GetComponentInChildren<Text>().text = BUTTON_DIE;
			lowerButton.GetComponentInChildren<Text>().text = BUTTON_CREDITS;			
		}
		else {
			title.text = TITLE_DEATH;
			topButton.GetComponentInChildren<Text>().text = BUTTON_DIE_AGAIN;
//			lowerButton.gameObject.SetActive(true);
			lowerButton.GetComponentInChildren<Text>().text = TITLE_MAIN_MENU;
		}
	}

	public void MenuBehaviors (string arg) {
		Debug.Log("menus are working");
		switch (arg) {

		case "Top": {
				if (!isDead)				
					Utilities.LoadLevel("StageSelect");
				else
					Utilities.LoadLevel("StageSelect");
				break;
			}
		case "Bottom": {
				if (!isDead)	
					Utilities.LoadLevel ("Credits");
				else
					Utilities.LoadLevel("MainMenu");
				break;
			}
		default:
			break;
		}
	}
}
