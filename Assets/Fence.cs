using UnityEngine;
using System.Collections;

public class Fence : LaneChanger {
	// Update is called once per frame
	void Update () {
        //baseUpdate();
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(gameObject.name + " hit " + col.gameObject.name);
        if (Utilities.hasMatchingTag(GGJTag.Player, col.gameObject))
        {
            Debug.Log(gameObject.name + " hit " + col.gameObject.name);
            GameObject parentPlayerObject = col.gameObject.transform.parent.gameObject;
            OmariTest playerScript = parentPlayerObject.GetComponent<OmariTest>();
            if (!playerScript.recentlyHit)
            {
                playerScript.recentlyHit = true;

                Physics2D.IgnoreCollision(col.collider, GetComponent<Collider2D>());
                parentPlayerObject.SendMessage("ChangeHealth", -1, SendMessageOptions.DontRequireReceiver);
                parentPlayerObject.SendMessage("StartFlicker", SendMessageOptions.DontRequireReceiver);
            }
            Destroy(gameObject);
        }
    }
}
