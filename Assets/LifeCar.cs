using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCar : MonoBehaviour {

    public float PvMax;
    public float CurrentPv;

    public void Damage(int i)
    {
        CurrentPv -= i;
        //if (CurrentPv <= 0)
        //    Destroy(gameObject);
    }
    // Use this for initialization
    void Start () {
        CurrentPv = PvMax;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
