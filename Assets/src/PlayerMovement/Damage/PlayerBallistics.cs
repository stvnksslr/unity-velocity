using UnityEngine;
using System.Collections;

public class PlayerBallistics : MonoBehaviour {

	float maxSpeed = 5f;

	// Update is called once per frame
	void Update () {
		// Move projectile
		Vector3 pos = transform.position;
		Vector3 direction = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
		pos += transform.rotation * direction;
	
		transform.position = pos;
	}
}
