using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	public int health = 5;

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Collision!");

		// TODO: This is terrible o god, please dont judge me
		if (coll.gameObject.tag == "Player") {
			Debug.Log ("Player has taken damage!");
			health--;
			Debug.Log ("Object Current Health: " + health);
		}

	 	if (coll.gameObject.tag == "Enemy") {
			Debug.Log ("Enemy Has taken damage!");
			health--;
			Debug.Log ("Object Current Health: " + health);
		}

		if (coll.gameObject.tag == "Asteroid") {
			Debug.Log ("Asteroids dont take damage!");
			health--;
			Debug.Log ("Object Current Health: " + health);
		}
	}

	void Update() {
		if (health <= 0) {
			Debug.Log ("Object's health has been reduced to zero, remobving it");
			Die ();
		}
	}

	void Die() {
		Destroy (gameObject);
	}

}
