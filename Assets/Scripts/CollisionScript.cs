using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

    void OnCollisionEnter(Collision c)
    {
        Debug.Log(c.gameObject.name);
        if(c.gameObject.tag == "sphere")
            c.gameObject.GetComponent<Transform>().localScale = new Vector3(2, 2, 2);
    }
}
