using UnityEngine;
using System.Collections;

public class CameraTracking : GGJBehaviour {
    public GameObject target;
    public float xOffset = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target){
            gameObject.transform.position = new Vector3(target.transform.position.x + xOffset, transform.position.y, transform.position.z) ;
		}
	}
}
