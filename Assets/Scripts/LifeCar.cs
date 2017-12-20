using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCar : MonoBehaviour {

    public float PvMax;
    public float CurrentPv;
    public Transform UiLife;

    public void Damage(int i)
    {
        CurrentPv -= i;
    }

    public void ResetPv()
    {
        CurrentPv = PvMax;
    }
    // Use this for initialization
    void Start () {
        ResetPv();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        // test
        if (Input.GetKey("n"))
            CurrentPv -= 1;
        if(CurrentPv >= 0)
        {
            float fact = CurrentPv / PvMax;
            UiLife.localScale = new Vector3(fact, 1, 1);
        }
    }
        
}
