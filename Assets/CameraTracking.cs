using UnityEngine;
using System.Collections;

public class CameraTracking : MonoBehaviour {
    public GameObject target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (target){
        gameObject.transform.position = new Vector3(target.transform.position.x, transform.position.y, transform.position.z) ;
			}
	}
}
