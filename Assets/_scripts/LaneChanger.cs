using UnityEngine;
using System.Collections;

public class LaneChanger : MonoBehaviour {

	const int MOVE_UP = 2;
	const int MOVE_DOWN = -2;

	LaneOrder myLane;

	void Start () {
		// we could randomize lanes?
		// talabamusic@me.com
		myLane = LaneOrder.Lane1;
	}

	void Update () {
		if (Input.GetKeyUp(KeyCode.W)) {
			MoveUp(MOVE_UP);
		}
		if (Input.GetKeyUp(KeyCode.S)) {
			MoveDown(MOVE_DOWN);
		}
	}

	void MoveUp (int zPosition) {
		if (myLane == LaneOrder.Lane1) {
			Move(zPosition);
			myLane = LaneOrder.Lane2;
		} else if  (myLane == LaneOrder.Lane2) {
			Move(zPosition);
			myLane = LaneOrder.Lane3;
		}
	}

	void MoveDown (int zPosition) {
		if  (myLane == LaneOrder.Lane3) {
			Move(zPosition);
			myLane = LaneOrder.Lane2;
		} else if  (myLane == LaneOrder.Lane2) {
			Move(zPosition);
			myLane = LaneOrder.Lane1;
		}
	}

	void Move (int moveZ) {
		transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + moveZ);
	}
}
