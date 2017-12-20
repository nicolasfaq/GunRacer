using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindScript : MonoBehaviour {

    public List<Vector3> OldPositions;
    public List<Quaternion> OldRotations;
    private Rigidbody r;
    private bool IsRewinding = false;

	// Use this for initialization
	void Start () {
        OldPositions = new List<Vector3>();
        OldRotations = new List<Quaternion>();
        r = GetComponent<Rigidbody>();
	}
	
    // faire une bombe et stocker les positions des eléménts à chaque frame dans les list pendant 3 seconde puis les lire à l'envers pour
    // faire revenir les objets en arrière

	// Update is called once per frame
	void Update () {
        //OldPositions.Add(transform.position);
        //OldRotations.Add(transform.rotation);

        if (Input.GetMouseButtonDown(1))
        {
            IsRewinding = true;
            r.isKinematic = true;
        }

        if (Input.GetMouseButtonUp(1))
        {
            IsRewinding = false;
            r.isKinematic = false;
        }

    }

    void FixedUpdate()
    {
        if (IsRewinding)
        {
            if(OldPositions.Count <= 0)
            {
                IsRewinding = false;
                return;
            }
            transform.position = OldPositions[0];
            OldPositions.RemoveAt(0);

            transform.rotation = OldRotations[0];
            OldRotations.RemoveAt(0);
        }
        else
        {
            OldPositions.Insert(0, transform.position);
            OldRotations.Insert(0, transform.rotation);
        }
    }
}
