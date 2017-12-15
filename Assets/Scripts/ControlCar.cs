using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCar : MonoBehaviour {

    public Transform[] Wheels;
    public float MotorPower;
    public float MaxTurn;

    private float InstantPower = 0.0f;
    private float Brake = 0.0f;
    private float WheelTurn = 0.0f;

    private Rigidbody CarRigidbody;

	// Use this for initialization
	void Start () {
        CarRigidbody = gameObject.GetComponent<Rigidbody>();
        CarRigidbody.centerOfMass = new Vector3(0, -0.5f, 0.3f);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        InstantPower = Input.GetAxis("Vertical") * MotorPower * Time.deltaTime;
        WheelTurn = Input.GetAxis("Horizontal") * MaxTurn;
        Brake = Input.GetKey("space") ? CarRigidbody.mass * 0.1f : 0.0f;

        GetCollider(0).steerAngle = WheelTurn;
        GetCollider(1).steerAngle = WheelTurn;

        Wheels[0].localEulerAngles = new Vector3(Wheels[0].localEulerAngles.x,
            GetCollider(0).steerAngle - Wheels[0].localEulerAngles.z + 90, Wheels[1].localEulerAngles.z);
        Wheels[1].localEulerAngles = new Vector3(Wheels[1].localEulerAngles.x,
            GetCollider(1).steerAngle - Wheels[1].localEulerAngles.z + 90, Wheels[1].localEulerAngles.z);

        Wheels[0].Rotate(0, -GetCollider(0).rpm / 60 * 360 * Time.deltaTime, 0);
        Wheels[1].Rotate(0, -GetCollider(1).rpm / 60 * 360 * Time.deltaTime, 0);
        Wheels[2].Rotate(0, -GetCollider(2).rpm / 60 * 360 * Time.deltaTime, 0);
        Wheels[3].Rotate(0, -GetCollider(3).rpm / 60 * 360 * Time.deltaTime, 0);

    }

    WheelCollider GetCollider(int n)
    {
        return Wheels[n].gameObject.GetComponent<WheelCollider>();
    }
}
