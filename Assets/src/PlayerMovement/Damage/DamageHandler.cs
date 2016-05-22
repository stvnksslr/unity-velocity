using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Collision!");
	}
}
