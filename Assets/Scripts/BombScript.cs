using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombScript : MonoBehaviour {

    private float timer = 0;
    public List<GameObject> ObjectsInRange;
    public int Puissance;

    private void OnTriggerEnter(Collider c)
    {
        if (c.GetComponent<Rigidbody>())
            ObjectsInRange.Add(c.gameObject);
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.GetComponent<Rigidbody>())
            ObjectsInRange.Remove(c.gameObject);
    }

    // Use this for initialization
    void Start () {
        ObjectsInRange = new List<GameObject>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        if (timer > 7)
        {
            foreach (GameObject g in ObjectsInRange)
            {
                g.GetComponent<Rigidbody>().AddForce(Vector3.Normalize(g.transform.position - transform.position) * Puissance);
            }
            Destroy(gameObject);
        }
    }
}
