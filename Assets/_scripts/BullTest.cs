﻿using UnityEngine;
using System.Collections;

public class BullTest : LaneChanger {
    public int speed = 10;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }
}
