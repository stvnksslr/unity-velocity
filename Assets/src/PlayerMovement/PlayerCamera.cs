using UnityEngine;
using System.Collections;

public class PlayerCamera : MonoBehaviour {

	public Transform myTarget;
	
	// Update is called once per frame
	void Update () {
		if (myTarget != null) {
			Vector3 targetPos = myTarget.position;
			targetPos.z = transform.position.z;
			transform.position = targetPos;
	}
}
}