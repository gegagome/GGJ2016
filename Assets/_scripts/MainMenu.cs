using UnityEngine;
using System.Collections;

public class MainMenu : GGJBehaviour {

	// Use this for initialization
	protected override void OnStart () {
		Invoke ("Play",1);
	}

	void Play()
	{
		Debug.Log ("can i get a hit?");
		Utilities.PlayBG (BackgroundAudio.MainTitle);
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
