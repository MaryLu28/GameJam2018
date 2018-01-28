using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WTControler : MonoBehaviour {

	public float angleRotation = 10f;
	public float currentAngle;
	public float successAngle;
	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentAngle = transform.localEulerAngles.z;
		
		if ( (currentAngle >= successAngle) && (currentAngle <= successAngle+10f)){
			GetComponent<AudioSource>().Stop();
			
		}
		if (Input.GetButtonDown("Right")) {
			transform.Rotate(0,0,angleRotation);
			GetComponent<AudioSource>().Play();	
		}
		if (Input.GetButtonDown("Left")) {
			transform.Rotate(0,0,-angleRotation);
			GetComponent<AudioSource>().Play();
		}
	}

}
