using UnityEngine;
using System.Collections;

public class CoinPickup: Pickupable{

	public float scoreIncrease = 500;

	public override void DoPickupTask(GameObject PlayerObject)
	{
		GameManager.score += scoreIncrease;
	}
}
