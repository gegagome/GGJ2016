using UnityEngine;
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

    void OnCollisionStay2D(Collision2D col)
    {
        if (Utilities.hasMatchingTag(GGJTag.Player, col.gameObject))
        {
            Debug.Log(gameObject.name + " hit " + col.gameObject.name);
        }
    }
}
