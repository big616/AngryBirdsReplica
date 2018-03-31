using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	public GameObject deathEffect;

	public float health = 4f;

	public static int EnemiesAlive = 0;

	void Start (){
		EnemiesAlive++;
	}
	
	

	void OnCollisionEnter2D(Collision2D colInfo)
	{
		if (colInfo.relativeVelocity.magnitude > health) {
			Die ();
		}
	}

	void Die (){
		Instantiate (deathEffect, transform.position, Quaternion.identity);
		EnemiesAlive--;
		if (EnemiesAlive <= 0)
			Debug.Log ("Lvl won!");
			
		Destroy (gameObject);
	}
}
