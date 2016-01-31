using UnityEngine;
using System.Collections;

public class Pickupable : LaneChanger {
	
		 void OnCollisionEnter2D(Collision2D whatICollidedWith)
	{
		if (Utilities.hasMatchingTag(GGJTag.Player,whatICollidedWith.gameObject))
		{
			DoPickupTask (whatICollidedWith.gameObject);
			Destroy(gameObject); 
		}
	}

	public virtual void DoPickupTask(GameObject PlayerObject)
	{

	}
}
