using UnityEngine;
using System.Collections;

public class Goal : GGJBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Did i compile");
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("I collide with shit: " + col.gameObject.name);
        if (Utilities.hasMatchingTag(GGJTag.Obstacle, col.gameObject))
        {
            Destroy(col.gameObject);
        }
        if (Utilities.hasMatchingTag(GGJTag.Player, col.gameObject))
        {
            //win
            Debug.Log("YOU WIN OMARI!");
        }
    }
}
