using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float x_speed = 6f;
	public float z_speed = 6f;
	public float relative_y_speed = 3f;

	public float current_position;
	Vector3 movement;                   // The vector to store the direction of the player's movement.
	Vector3 depth_movement;            //The vector to store the direction of the player's depth movement

	public Rigidbody rb;
	public float depth_position;

	//Limits
	public float max_depth = 5;
	public float min_depth = -5;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		depth_position = 0;

	}


	// Update is called once per frame
	void FixedUpdate () {

		// Horizontal movement
		float moveHorizontal = Input.GetAxis ("Horizontal");

		movement.Set(moveHorizontal * x_speed * Time.fixedDeltaTime,0,0);

		//Depth movement
		float moveDepth = Input.GetAxis("Vertical");

		depth_movement.Set (0, moveDepth * relative_y_speed  * Time.fixedDeltaTime, moveDepth * z_speed * Time.fixedDeltaTime);

		rb.MovePosition (transform.position + depth_movement + movement);
	}

}

