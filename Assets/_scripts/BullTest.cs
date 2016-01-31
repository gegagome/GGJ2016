using UnityEngine;
using System.Collections;

public class BullTest : LaneChanger {
    public int speed = 10;
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        baseUpdate();
        GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
    }

	void OnCollisionEnter2D(Collision2D col)
	{
		if (Utilities.hasMatchingTag(GGJTag.Player, col.gameObject))
		{
			Debug.Log(gameObject.name + " hit " + col.gameObject.name);
            Debug.Log("|||BullLayer: " + gameObject.layer + " Player Layer " + col.gameObject.layer + "|||");
            Debug.Log("|||Bull Z: " + gameObject.transform.position.z + " Player Z: " + col.gameObject.transform.position.z + " |||");
            Debug.Log("|||Bull Curz: " + curZ);
            GameObject parentPlayerObject = col.gameObject.transform.parent.gameObject;
			OmariTest playerScript = parentPlayerObject.GetComponent<OmariTest> ();
			if (!playerScript.recentlyHit) {
				playerScript.recentlyHit = true;
				Debug.Log("come on");

				Physics2D.IgnoreCollision (col.collider, GetComponent<Collider2D> ());
				parentPlayerObject.SendMessage ("ChangeHealth", -1, SendMessageOptions.DontRequireReceiver);
				parentPlayerObject.SendMessage ("StartFlicker", SendMessageOptions.DontRequireReceiver);
			}
			Destroy (gameObject);
		}
	}
}
