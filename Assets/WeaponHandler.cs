using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponHandler : MonoBehaviour {

    public GameObject CurentWeapon;
    public KeyCode shoot;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKeyDown(shoot))
        { 
            if (CurentWeapon != null)
            {
                gameObject.GetComponentInChildren<ShootScript>().Shoot();
            }
        }
	}

    //IEnumerator CallShoot()
    //{
    //    yield return WaitForEndOfFrame;
    //    gameObject.GetComponentInChildren<ShootScript>().Shoot();
    //}
}
