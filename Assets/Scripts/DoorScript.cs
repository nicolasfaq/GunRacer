using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

    private bool IsOpen = false;
    public float Speed;
    public Vector3 StartPosition;
    public Vector3 EndPosition;


    public Color StColor, EndColor, CurrentColor;

    [Range(0,1)]        //permet de modifier l'interface de l'editeur unity
    public float timer = 0;

    private void OnTriggerEnter(Collider c)
    {
        if(c.tag == "Player")
        {
            //Destroy(gameObject, 5);
            IsOpen = true;
            timer = 0;
        }
        
    }

    private void OnTriggerExit(Collider c)
    {
        if (c.tag == "Player")
        {
            //Destroy(gameObject);
            IsOpen = false;
            timer = 1;
        }          
    }

    // Update is called once per frame
    void Update () {
        if (IsOpen)
        {
            //float f = Time.deltaTime * Speed;
            //GetComponent<Transform>().localPosition += new Vector3(0, f, 0);
            timer += Time.deltaTime;
        }
        else
        {
            timer -= Time.deltaTime;
        }
        //Debug.Log(Mathf.Lerp(0, 10, timer));
        //CurrentColor = Color.Lerp(StColor, EndColor, timer);

        transform.localPosition = Vector3.Lerp(StartPosition, EndPosition, (Mathf.Sin(Time.time)+1)/2); // sinus afin d'avoir une valeur qui oscille régulièrement entre 1 et -1 (on a besoin entre 1 et 0)
    }
}