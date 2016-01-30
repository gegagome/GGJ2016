using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void OnGUI () {
		if (GUI.Button (new Rect (Screen.width / 3, 50, Screen.width / 4, Screen.height / 10), "StartGame")) {
			Utilities.LoadLevel ("StageSelect");
		} 
		else if (GUI.Button (new Rect (Screen.width / 3, 150, Screen.width / 4, Screen.height / 10), "Credits")) {
			Utilities.LoadLevel ("Credits");
		} 
	}
}
