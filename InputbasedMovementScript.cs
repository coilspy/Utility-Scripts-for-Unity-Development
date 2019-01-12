using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputbasedMovementScript : MonoBehaviour {

    public float Speed;
        
	void FixedUpdate () {
        this.transform.position += new Vector3(Input.GetAxis("Horizontal") * Speed, 0, Input.GetAxis("Vertical") * Speed) * Time.deltaTime;
	}
}
