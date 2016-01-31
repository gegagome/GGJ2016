using UnityEngine;
using System.Collections;

public class Stage : GGJBehaviour {
	public static Stage[] GameStageList;
	public static int StageListCount;
	public bool unlocked = true;
	public Level[] LevelsInStage;
	// Use this for initialization


	public static void InitializeStageList()
	{
		GameStageList = new Stage[]{ new Stage () , new Stage()};
		StageListCount = GameStageList.Length;
	}
}
