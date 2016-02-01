using UnityEngine;
using System.Collections;

public class LevelInitializer : MonoBehaviour {
    public float length;
	public	SpawnSystem theSpawnSystem;
	public int textDrawIndicator;
	Rect drawLocation; //location to draw variable text (probably need to move this to new UGUI)
	public GUIStyle messageDisplay;
	bool TriggeredLevelCompleteWorkflow = false;
	// Use this for initialization
	void Start () {
		StartCoroutine (StartRunningLevel());   
		drawLocation = new Rect(Screen.width/4,Screen.height/10,Screen.width/2,80);

	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.LevelComplete)
		{
			if (!TriggeredLevelCompleteWorkflow) {
				TriggeredLevelCompleteWorkflow = true;
				textDrawIndicator =6;
				Invoke("LevelCompleteStuff",5);
			}
		}
	}

	IEnumerator StartRunningLevel()
	{
		GameManager.LevelRunning = false;
		Utilities.PlayBG (BackgroundAudio.Level1Loop);
		//start sound effect of getting hit
		yield return new WaitForSeconds(.5f);
		textDrawIndicator = 1;
		Utilities.PlayEffect (AudioClipSymbol.AnnLv1);
		yield return new WaitForSeconds(1f);
		textDrawIndicator = 2;
		Utilities.PlayEffect (AudioClipSymbol.AnnCD3);
		yield return new WaitForSeconds (.33f);
		textDrawIndicator = 3;
		Utilities.PlayEffect (AudioClipSymbol.AnnCD2);
		yield return new WaitForSeconds (.33f);
		textDrawIndicator = 4;
		Utilities.PlayEffect (AudioClipSymbol.AnnCD1);
		yield return new WaitForSeconds (.33f);
		textDrawIndicator = 5;
		GameManager.LevelRunning = true;
		if (theSpawnSystem) {
			theSpawnSystem.SpawnSystemActive = true;
		}
		yield return new WaitForSeconds (.33f);
		textDrawIndicator = 0;
	}

	void OnGUI()
	{

		if (textDrawIndicator == 1)
		{
			GUI.Label(drawLocation,"LEVEL START!",messageDisplay);
		}
		else if (textDrawIndicator == 2)
		{
			GUI.Label(drawLocation,"3!",messageDisplay);
		}
		else if (textDrawIndicator == 3)
		{
			GUI.Label(drawLocation,"2!",messageDisplay);
		}
		else if (textDrawIndicator == 4)
		{
			GUI.Label(drawLocation,"1!",messageDisplay);
		}
		else if (textDrawIndicator == 5)
		{
			GUI.Label(drawLocation,"RUN!",messageDisplay);
		}else if (textDrawIndicator == 6)
		{
			GUI.Label(drawLocation,"LEVEL COMPLETE!",messageDisplay);
		}
	}

	void LevelCompleteStuff()
	{
		Utilities.LoadLevel ("StageSelect");
	}
}
