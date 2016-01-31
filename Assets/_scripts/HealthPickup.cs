using UnityEngine;
using System.Collections;

public class HealthPickup : Pickupable {

	public int healthToHeal = 1;

	public override void DoPickupTask(GameObject PlayerObject)
	{
		PlayerObject.SendMessage ("ChangeHealth",1,SendMessageOptions.DontRequireReceiver);
	}
}
