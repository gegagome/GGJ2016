using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Stage  {
	public static List<Stage> GameStageList;
	//public static Stage[] GameStageList;
	public static int StageListCount;
	public bool unlocked = true;
	public List<Level> LevelsInStage;
	// Use this for initialization

	public Stage()
	{
		LevelsInStage = new List<Level> ();
	}
	public static void InitializeStageList()
	{
		Debug.Log ("this is being hit the stage initilization");
		//GameStageList = new Stage[]{ new Stage () , new Stage()};
		GameStageList = new List<Stage>();


		Stage A = new Stage ();
		Level A1 = new Level(10,10,10,10,10,50,90,2);

		A.LevelsInStage.Add (A1);
		GameStageList.Add (A);




		GameStageList.Add (new Stage ());
		GameStageList.Add (new Stage ());
		GameStageList.Add (new Stage ());

		GameStageList.Add (new Stage ());

		StageListCount = GameStageList.Count;
	}
}
