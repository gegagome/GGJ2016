﻿using UnityEngine;
using System.Collections;

public class Level {

	public float BrownBullChance;
	public float RedEventChance;
	public float BlueBullChance;
	public float OrangeBullChance;
	public float YellowEventChance;
    public float FenceChance;
    public float CarChance;
	public float TripleBullEventChance;
	public float LevelLengthInTime;
	public float SpawnTimeInterval = 2f;
	public float DifficultyTimeRamp = 90f;

	// Use this for initialization
	void Start () {
	
	}
	public Level()
	{
		this.BrownBullChance = 10;
		this.RedEventChance = 10;
		this.BlueBullChance = 10;
		this.OrangeBullChance = 10;
		this.YellowEventChance = 30;
        this.FenceChance = 10;
        this.CarChance = 10;
		this.TripleBullEventChance = 10;
		this.LevelLengthInTime = 120;
		this.DifficultyTimeRamp = 90f;
	}
	public Level (float BrownBullChance, float RedEventChance, float BlueBullChance, float OrangeBullChance, float YellowEventChance, float FenceChance, float CarChance, float TripleBullChance, float LevelLengthInTime, float SpawnTimeInterval, float DifficultyTimeRamp)
	{
		this.BrownBullChance = BrownBullChance;
		this.RedEventChance = RedEventChance;
		this.BlueBullChance = BlueBullChance;
		this.OrangeBullChance = OrangeBullChance;
		this.YellowEventChance = YellowEventChance;
        this.FenceChance = FenceChance;
        this.CarChance = CarChance;
        this.TripleBullEventChance = TripleBullChance;
		this.LevelLengthInTime = LevelLengthInTime;
		this.SpawnTimeInterval = SpawnTimeInterval;
		this.DifficultyTimeRamp = DifficultyTimeRamp;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
