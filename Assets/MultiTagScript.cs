using UnityEngine;
using System.Collections;

public enum GGJTag{
	Player,
	Obstacle,
	Bull,
	Goal,
	Pickup,
}

public class MultiTagScript : MonoBehaviour
{

	public GGJTag[] objectTags;

	public bool objectHasTag (GGJTag tagToCheckFor)
	{
		if ((objectTags.Length == 0)) {
			return false;
		}
		foreach (GGJTag curTag in objectTags) {
			if (curTag.Equals (tagToCheckFor)) {
				return true;
			}
		}
		return false;
	}
}
