using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour {

    public Transform BulletStartPosition;
    public GameObject PrefabBullet;
    public int MaxBullet;
    public int CurrentBullet = 5;
    public int DamagePoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //if (CurrentBullet == 0)
        //    Destroy(gameObject);

    }

    public void Shoot()
    {

        CurrentBullet -= 1;
        GameObject Bullet = Instantiate<GameObject>(PrefabBullet);
        Bullet.transform.position = BulletStartPosition.position;
        Bullet.GetComponent<Rigidbody>().AddForce(BulletStartPosition.forward * 650);

        // Destroy the bullet after 2 seconds
        DestroyObject(Bullet, 3.0f);
      
        if (CurrentBullet<=0)
        {
            Destroy(gameObject);
        }
    }

    public void Reload()
    {
        CurrentBullet = MaxBullet;
    }
}
