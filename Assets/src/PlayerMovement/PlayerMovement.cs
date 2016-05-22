using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	// TODO: Newtonian or Arcade style moevement?

	// TODO: need to class ships somehow?
	//speed controls
	private float maxSpeed = 5f;
	private float maxRotSpeed = 180f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		// player movement up down, the vertical keybinding controls both the action and negative
		// Currently bound to: up-arrow / w || down-arrow / s
		// Returns a float from -1.0 to +1.0

		// Rotate Ship
		// Grabs the Quaternion, whose math seems to be :catdrugs:
		Quaternion rot = transform.rotation;

		// Grab the z Euler Angle (idk wtf a Euler is :argh:
		float z = rot.eulerAngles.z;

		// Change Z angle based on input
		z -= Input.GetAxis("Horizontal") * maxRotSpeed * Time.deltaTime;

		// Recreate the quaternion
		rot = Quaternion.Euler(0, 0, z);

		// feed quaternion into rotation
		transform.rotation = rot;	

		// Move Ship
		Vector3 pos = transform.position;
		Vector3 direction = new Vector3 (0, Input.GetAxis ("Vertical") * maxSpeed * Time.deltaTime, 0);
		pos += rot * direction;

		transform.position = pos;
	}
}