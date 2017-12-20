using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SpiderScript : LifeScript {

    public float Speed;
    public Transform Destination;
    public LifeBarScript life;

    public override void Damage(int d)
    {
        base.Damage(d);
        GetComponent<Animator>().SetInteger("Pv", Pv);  // Set le paramètre Pv de l'animation à la meme valeur que dans le script
        if (Pv <= 0)
        {
            GetComponent<BoxCollider>().enabled = false; // désactive la hitbox
            GetComponent<NavMeshAgent>().enabled = false; // stop l'objet allant vers sa destination
            Destroy(this);
        }
        life.Damage(d);
            
    }
	// Use this for initialization
	void Start () {
        gameObject.GetComponent<Animator>().SetInteger("Pv", Pv);
        life.PvMax = Pv;
        
	}
	
	// Update is called once per frame
	void Update () {
        GetComponent<NavMeshAgent>().destination = Destination.position;
    }
}
