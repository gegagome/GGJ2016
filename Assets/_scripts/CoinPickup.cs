using UnityEngine;
using System.Collections;

public class CoinPickup: Pickupable{

	public float scoreIncrease = 500;

	public override void DoPickupTask(GameObject PlayerObject)
	{
		GameManager.score += scoreIncrease;
		Utilities.PlayEffect (AudioClipSymbol.CoinGrabbed);
	}

	void FixedUpdate () {
		gameObject.transform.Rotate(new Vector3(0f, 2f, 0));
	}
}
