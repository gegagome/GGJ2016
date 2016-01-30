using UnityEngine;
using System.Collections;

public class BullTest : LaneChanger {

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody2D>().velocity = new Vector2(5, 0);
    }
}
