using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {


	public int doorNumber;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider otherObject)
	{
		Debug.Log ("Collision");
		if (otherObject.gameObject.name == "main_character")
		{
			if (doorNumber == 1) {
				Vector3 newPosition = otherObject.gameObject.transform.position;
				newPosition = new Vector3 (-5.145413f, 5.0956f, 6.497959f);
				otherObject.gameObject.transform.position = newPosition;
				Debug.Log ("Teleport");
			}

			if (doorNumber == 2) {
				Vector3 newPosition = otherObject.gameObject.transform.position;
				newPosition = new Vector3 (-1.177372f, 1.1322f, 6.452938f);
				otherObject.gameObject.transform.position = newPosition;
				Debug.Log ("Teleport");
			}
		}
	}
}
