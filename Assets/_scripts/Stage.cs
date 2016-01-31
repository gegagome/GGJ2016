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

        //Brown, Red, Blue, Orange, Yellow, Fence, Car, Triple, Level_Length, Spawn_Time

		Stage A = new Stage (); 
        Level A1 = new Level(50, 10, 20, 0, 0, 10, 0, 0, 60, 2);
        Level A2 = new Level(30, 10, 30, 0, 0, 20, 0, 10, 60, 2);
        Level A3 = new Level(30, 10, 25, 15, 0, 10, 0, 10, 60, 2);

        Stage B = new Stage();
        Level B1 = new Level(20, 10, 30, 0, 10, 10, 15, 5, 60, 2);
        Level B2 = new Level(20, 10, 20, 10, 10, 10, 15, 5, 60, 2);
        Level B3 = new Level(5, 10, 25, 10, 15, 5, 20, 10, 60, 2);

        A.LevelsInStage.Add(A1);
        A.LevelsInStage.Add(A2);
        A.LevelsInStage.Add(A3);

        B.LevelsInStage.Add(B1);
        B.LevelsInStage.Add(B2);
        B.LevelsInStage.Add(B3);

		GameStageList.Add(A);
        GameStageList.Add(B);


		GameStageList.Add (new Stage ());
		GameStageList.Add (new Stage ());
		GameStageList.Add (new Stage ());

		GameStageList.Add (new Stage ());

		StageListCount = GameStageList.Count;
	}
}
