using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody))]
public class InputbasedRigidbodyForceMovementScript : MonoBehaviour {
    public float Speed;
    private Rigidbody rigidbody;
	// Use this for initialization
	void Start () {
        rigidbody = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {   
        float horizontalAxisValue = Input.GetAxis("Horizontal");
        float verticalAxisValue = Input.GetAxis("Vertical");

        Vector3 movementVector = new Vector3(horizontalAxisValue, 0, verticalAxisValue);
        rigidbody.AddForce(movementVector * Speed);
	}
}
