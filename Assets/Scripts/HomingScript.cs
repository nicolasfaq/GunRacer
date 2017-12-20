using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomingScript : MonoBehaviour {

    public Transform TargetTransform;
    //public float timer = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //timer += Time.deltaTime;
        transform.localPosition = Vector3.Lerp(transform.localPosition, TargetTransform.localPosition, 0.1f);

    }
}
