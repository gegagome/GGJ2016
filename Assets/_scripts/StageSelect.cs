using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelect : GGJBehaviour
{
	public DPadButtons dPadScript1;
	public Texture2D background; //background to draw behind everything
	public Texture2D selectionBoxIcon; //box hovers over current selection
	int selectionIndexStage=0; //represents current stage selection
	int selectionIndexLevel=0;
	private bool drawBox; //toggle whether or not to draw the box for special effect
	public GUIStyle numbersDisplay; //for font,size, and color
	public Text StageDataTextArea;

	// Use this for initialization
	protected override void OnStart () {
		drawBox = true;

	}



	// Update is called once per frame
	void Update ()
	{
		//if (Input.GetButtonDown ("Right1")) { //moves right if not at end of array
		//if (dPadScript1.RightPressed()) {
		if (Input.GetKeyDown (KeyCode.D)) { //moves left if not at beginning of array
			if (selectionIndexLevel < Stage.GameStageList[selectionIndexStage].LevelsInStage.Count - 1) {
				selectionIndexLevel++;
				UpdateStageInfo ();
			}
		}
		//if (dPadScript1.LeftPressed ()) { //moves left if not at beginning of array
		if (Input.GetKeyDown (KeyCode.A)) { //moves left if not at beginning of array
		if (selectionIndexLevel > 0) {
				selectionIndexLevel--;
				UpdateStageInfo ();
			}
		}

		if (Input.GetKeyDown (KeyCode.S)) { //moves left if not at beginning of array
			if (selectionIndexStage < Stage.StageListCount - 1) {
				selectionIndexStage++;
				UpdateStageInfo ();
			}
		}
		//if (dPadScript1.LeftPressed ()) { //moves left if not at beginning of array
		if (Input.GetKeyDown (KeyCode.W)) { //moves left if not at beginning of array
			if (selectionIndexStage > 0) {
				selectionIndexStage--;
				UpdateStageInfo ();
			}
		}




		if (Input.GetButtonDown("Jump")) //confirm choice if currently highlighting an unlocked stage
		{
			SpawnSystem.levelReference = Stage.GameStageList [selectionIndexStage].LevelsInStage [selectionIndexLevel];
			GoToArena ();
		}
	}

	void UpdateStageInfo()
	{
		Stage currStageHighlighted = Stage.GameStageList [selectionIndexStage]; //get the stage data for the currently highlighted stage
		//StageDataTextArea.text = "Stage: " + currStageHighlighted.stageName + "\nUnlocked?: " + currStageHighlighted.isUnlocked + "\nNumber of Rooms: " + currStageHighlighted.listOfRooms.Length +"\nAverage Room Rating: " + 999;
	}

	void OnGUI ()
	{
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), background);
		// Debug.Log ("Stage Selection Index " + selectionIndexStage);
		//GUI.Label (new Rect (0,0, 200, 200), "Score", numbersDisplay);
		GUI.Label (new Rect (Screen.width / 2 - 50, Screen.height / 8, 100, 100), "Stage: " + (selectionIndexStage+1), numbersDisplay);
		GUI.Label (new Rect (Screen.width / 2 - ((selectionIndexLevel) * 150) - 175, Screen.height / 3 - 37.5f, 100, 100), "Level: ", numbersDisplay);


		for (int j = 0; j < Stage.GameStageList[selectionIndexStage].LevelsInStage.Count; j++) {
			//for loop condition makes selectionIndex always greater than counter, so all textures here will be drawn left of the center
			GUI.Label (new Rect (Screen.width / 2 - ((selectionIndexLevel - j) * 150) - 50, Screen.height / 3 - 37.5f, 100, 100), "" + (j+1), numbersDisplay);
		}
		for (int j = selectionIndexStage; j < Stage.StageListCount; j++) {
			//selectionIndex = counter, so texture is drawn exactly at the center
			//rest of for loop condition makes selectionIndex always less than counter, so rest of textures will be drawn right of the center
			GUI.Label (new Rect (Screen.width / 2 + ((j - selectionIndexLevel) * 150) - 50, Screen.height / 3 - 37.5f, 100, 100), "" + (j+1), numbersDisplay);
		}/*for (int i = 0; i < Stage.StageListCount; i++) {
			//for loop condition makes selectionIndex always greater than counter, so all textures here will be drawn left of the center
			GUI.Label (new Rect (Screen.width / 2 - ((selectionIndexStage - i) * 150) - 50, Screen.height / 3 - 37.5f, 100, 100), "" + (i+1), numbersDisplay);
		}
		for (int i = selectionIndexStage; i < Stage.StageListCount; i++) {
			//selectionIndex = counter, so texture is drawn exactly at the center
			//rest of for loop condition makes selectionIndex always less than counter, so rest of textures will be drawn right of the center
			GUI.Label (new Rect (Screen.width / 2 + ((i - selectionIndexStage) * 150) - 50, Screen.height / 3 - 37.5f, 100, 100), "" + (i+1), numbersDisplay);
		}*/
		if (drawBox) {
			GUI.DrawTexture (new Rect (Screen.width / 2 - 75, Screen.height / 3 - 75, 150, 150), selectionBoxIcon); //box should be cocentric with numbers
		}
	}

	public void GoToArena()
	{
		Utilities.LoadLevel("RunningScene");
	}
}