using UnityEngine;
using System.Collections;

public class DamageHandler : MonoBehaviour {

	int health = 10;

	void OnCollisionEnter2D(Collision2D coll) {
		Debug.Log ("Collision!");

		if (coll.gameObject.tag == "Player") {
			Debug.Log ("Player has taken damage!");
			--health;
			Debug.Log ("Object Current Health: " + health);

			if (health <= 0) {
				Die();
			}
		}

	 	if (coll.gameObject.tag == "Enemy") {
			Debug.Log ("Enemy Has taken damage!");
		}

		if (coll.gameObject.tag == "Asteroid") {
			Debug.Log ("Asteroids dont take damage!");
		}

	}

	void Die() {
		Destroy (gameObject);
	}

}
