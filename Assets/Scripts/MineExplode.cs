﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineExplode : MonoBehaviour {

	public AudioClip Hurt;
	public AudioClip Explosion;
	private GameObject Mine;

	// Use this for initialization
	void Start () {
		transform.GetChild (0).GetComponent<ParticleSystem> ().Stop();

	}
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player") {
			transform.GetChild (0).GetComponent<ParticleSystem> ().Play();

		}
	}
}
