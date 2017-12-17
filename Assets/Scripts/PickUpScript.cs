using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider c)
    {
        if(c.gameObject.tag == "Player")
        {
            Debug.Log("Car has entered");
            this.gameObject.transform.parent = c.transform;
            if (this.gameObject.tag == "Rocket")
            {
                this.gameObject.transform.localPosition = new Vector3(-0.12f, 1.07f, -0.04f);
            }
            
        }
        
    }
}
