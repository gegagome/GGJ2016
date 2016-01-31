using UnityEngine;
using System.Collections;

public class Bull : MonoBehaviour {

	public GameObject frontWheel;
	public GameObject rearWheel;
	float speed = 30;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void FixedUpdate () {
		float rot;
		rot =+ 10 * speed * Time.deltaTime;

		frontWheel.transform.Rotate(new Vector3(0,rot,0));
		rearWheel.transform.Rotate(new Vector3(0,rot,0));
	}
}
