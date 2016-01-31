using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class StageSelect : GGJBehaviour
{
	public DPadButtons dPadScript1;
	public Texture2D background; //background to draw behind everything
	public Texture2D selectionBoxIcon; //box hovers over current selection
	int selectionIndex; //represents current stage selection
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
		if (dPadScript1.RightPressed()) {
			if (selectionIndex < Stage.StageListCount - 1) {
				selectionIndex++;
				UpdateStageInfo ();
			}
		}


		if (dPadScript1.LeftPressed ()) { //moves left if not at beginning of array
			if (selectionIndex > 0) {
				selectionIndex--;
				UpdateStageInfo ();
			}
		}


		if (Input.GetButtonDown("Jump")) //confirm choice if currently highlighting an unlocked stage
		{
			
		}
	}

	void UpdateStageInfo()
	{
		Stage currStageHighlighted = Stage.GameStageList [selectionIndex]; //get the stage data for the currently highlighted stage
		//StageDataTextArea.text = "Stage: " + currStageHighlighted.stageName + "\nUnlocked?: " + currStageHighlighted.isUnlocked + "\nNumber of Rooms: " + currStageHighlighted.listOfRooms.Length +"\nAverage Room Rating: " + 999;
	}

	void OnGUI ()
	{
			for (int i = 0; i < selectionIndex; i++) {
				//for loop condition makes selectionIndex always greater than counter, so all textures here will be drawn left of the center
				GUI.Label (new Rect (Screen.width / 2 - ((selectionIndex - i) * 150) - 50, Screen.height / 3 - 37.5f, 100, 100), "" + (i+1), numbersDisplay);
			}
			
		for (int i = selectionIndex; i < Stage.StageListCount; i++) {
			//selectionIndex = counter, so texture is drawn exactly at the center
			//rest of for loop condition makes selectionIndex always less than counter, so rest of textures will be drawn right of the center
			GUI.Label (new Rect (Screen.width / 2 + ((i - selectionIndex) * 150) - 50, Screen.height / 3 - 37.5f, 100, 100), "" + (i+1), numbersDisplay);
		}
			
		if (drawBox) {
			GUI.DrawTexture (new Rect (Screen.width / 2 - 75, Screen.height / 3 - 75, 150, 150), selectionBoxIcon); //box should be cocentric with numbers
		}


	}

	public void GoToArena()
	{
		Utilities.LoadLevel("RunningScene");
	}
}