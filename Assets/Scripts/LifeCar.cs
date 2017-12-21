using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCar : MonoBehaviour {

    public float PvMax;
    public float CurrentPv;
    public Transform UiLife;

    public string Respawn;

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
        if (Input.GetKey(Respawn))
            CurrentPv = 0;
        if(CurrentPv >= 0)
        {
            float fact = CurrentPv / PvMax;
            UiLife.localScale = new Vector3(fact, 1, 1);
        }
    }

    private void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "Bullet")
        {
            Damage(c.GetComponent<DamageScript>().DamagePoint);
            Destroy(c.gameObject);
        }
            
    }

}
