using UnityEngine;
using System.Collections;

public class Goal : GGJBehaviour {
	
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
			Debug.Log(gameObject.transform.rotation +" rotation");
			Debug.Log(gameObject.transform.position +" position");

            Debug.Log("YOU WIN OMARI!");
        }
    }
}
