using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereScript : MonoBehaviour {

    public float Speed;
    public Color[] Color;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        float f = Time.deltaTime * Speed;
        GetComponent<Transform>().localScale += new Vector3(f,f,f);

    }
}
