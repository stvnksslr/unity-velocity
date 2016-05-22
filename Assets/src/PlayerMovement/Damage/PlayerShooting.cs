using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
	public float fireDelay = 0.25f;
	public GameObject bulletPrefab;
	float coolDownTimer = 0;

	// Update is called once per frame
	void Update ()
	{
		coolDownTimer -= Time.deltaTime;
		if(Input.GetButton("Fire1") && coolDownTimer <= 0) {
		// GUNS
			Debug.Log("BLAM!");
			coolDownTimer = fireDelay;
			Instantiate (bulletPrefab, transform.position, transform.rotation);
		}
	
	}
}

