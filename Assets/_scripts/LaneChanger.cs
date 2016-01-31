using UnityEngine;
using System.Collections;

public class LaneChanger : MonoBehaviour {

	public int myDifficulty;
	uint laneNumber;
	SpriteRenderer myRenderer;
	Rigidbody myRB;
    private int curZ;
	public LaneOrder myLane;



	public uint LaneNumber {
		get {
			return laneNumber;
		}
		set {
			if (value > 3) {
				value = 3;
				Debug.Log("No more than three lanes are allowed! sorry.");
			}
		}
	}

	void Awake () {
		myRenderer = GetComponent<SpriteRenderer>();
		myRB = GetComponent<Rigidbody>();
        curZ = 3;
	}

    void Update ()
    {
        if (myRB != null) {
            myRB.transform.position = new Vector3(transform.position.x, transform.position.y, curZ);
        }
    }

	void Start () {
		myLane = LaneOrder.Lane3;
	}
//
//	void Update () {
//		if (Input.GetKeyUp(KeyCode.W)) {
//			MoveUp();
//		}
//		if (Input.GetKeyUp(KeyCode.S)) {
//			MoveDown();
//		}
//		Debug.Log(gameObject.name + " is currently in layer: " +  gameObject.layer);
//	}

	public void MoveUp () {
		if (myLane == LaneOrder.Lane3) {
			SetLane(2);
		} else if  (myLane == LaneOrder.Lane2) {
			SetLane(1);
		}
	}

	public void MoveDown () {
		if  (myLane == LaneOrder.Lane1) {
			SetLane(2);
		} else if  (myLane == LaneOrder.Lane2) {
			SetLane(3);
		}
	}

	public void Move (int moveZ) {
        curZ = moveZ;
        if (myRB != null)
        {
            myRB.position = new Vector3(transform.position.x, transform.position.y, moveZ);
            //		transform.position = new Vector3(transform.position.x, transform.position.y, moveZ);
        }
        }

	public void SetLane (int aLane) {
		if (aLane == 1) {
			myLane = LaneOrder.Lane1;
			Move(6);
			gameObject.layer = Utilities.Row1;
			if (myRenderer) {
				myRenderer.sortingOrder = aLane;
			}
		}
		else if (aLane == 2) {
			myLane = LaneOrder.Lane2;
			Move(3);
			gameObject.layer = Utilities.Row2;
			if (myRenderer) {
				
				myRenderer.sortingOrder = aLane;
			}
		}
		else if (aLane == 3) {
			myLane = LaneOrder.Lane3;
			Move(0);
			gameObject.layer = Utilities.Row3;
			if (myRenderer) {
				
				myRenderer.sortingOrder = aLane;
			}
		}
		else if (aLane == 0)
		{
			myLane = LaneOrder.All;
			gameObject.layer = Utilities.AllRows;
		}
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(gameObject.name + " hit " + col.gameObject.name);
    }
}
