using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DorrScript2 : MonoBehaviour {

    public Vector3 StartPosition;
    public Vector3 EndPosition;
    public float timer = 0;
    //private bool OpenDoor = false;
    private bool DoorIsInMovement = false;

    //private void OnTriggerEnter(Collider c)
    //{
    //    if (c.tag == "Player")
    //        OpenDoor = true;
    //}

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    //void Update () {
    //       if (OpenDoor)
    //       {
    //           timer += Time.deltaTime;
    //           transform.position = Vector3.Lerp(StartPosition, EndPosition, timer);
    //       }
    //}

    private void OnTriggerEnter(Collider c)
    {
        if (c.tag == "Player")
        {
            
            StartCoroutine(OpenDoorCoroutine());
        }
            
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {

            StartCoroutine(CloseDoorCoroutine());
        }

    }

    IEnumerator OpenDoorCoroutine()
    {
        //yield return new WaitUntil( () =>
        //{
        //    return !DoorIsInMovement;
        //});

        while(DoorIsInMovement)
            yield return new WaitForEndOfFrame();
        DoorIsInMovement = true;
        while (timer < 1)
        {
            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(StartPosition, EndPosition, timer);
            yield return new WaitForEndOfFrame();
        }
        DoorIsInMovement = false;
        timer = 0;
    }

    IEnumerator CloseDoorCoroutine()
    {
        while (DoorIsInMovement)
            yield return new WaitForEndOfFrame();

        DoorIsInMovement = true;
        while (timer < 1)
        {
            timer += Time.deltaTime;
            transform.position = Vector3.Lerp(EndPosition, StartPosition, timer);
            yield return new WaitForEndOfFrame();
        }
        DoorIsInMovement = false;
        timer = 0;
    }
}
