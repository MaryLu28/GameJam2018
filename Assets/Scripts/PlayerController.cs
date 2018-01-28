using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float x_speed = 5f;
	public float z_speed = 5f;
	public float relative_y_speed = 1.5f;

	public float current_position;
	Vector3 movement;                   // The vector to store the direction of the player's movement.
	Vector3 depth_movement;            //The vector to store the direction of the player's depth movement

	public Rigidbody rb;
	public float depth_position;

	//Limits
	public float max_depth = 5;
	public float min_depth = -5;

	private Animator anim;
	public float scale;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.velocity = Vector3.zero;
		depth_position = 0;
		anim = GetComponent<Animator>();

	}


	// Update is called once per frame
	void FixedUpdate () {

		// Horizontal movement
		float moveHorizontal = Input.GetAxis ("Horizontal");
		if (Mathf.Abs(moveHorizontal) > 0) {
			anim.SetFloat("Velocity", Mathf.Abs(moveHorizontal));
		}

		movement.Set(moveHorizontal * x_speed * Time.fixedDeltaTime,0,0);

		if (moveHorizontal < -0.1f) {
			GetComponent<SpriteRenderer>().flipX = false;
		}
		if (moveHorizontal > 0.1f) {
			GetComponent<SpriteRenderer>().flipX = true;
		}
		

		//Depth movement
		float moveDepth = Input.GetAxis("Vertical");
		if (Mathf.Abs(moveDepth) > 0) {
			anim.SetFloat("Velocity", Mathf.Abs(moveDepth));
		}

		depth_movement.Set (0, moveDepth * relative_y_speed  * Time.fixedDeltaTime, moveDepth * z_speed * Time.fixedDeltaTime);

		rb.MovePosition (transform.position + depth_movement + movement);

//		float scale = Mathf.Pow (transform.position.z, -relativate_scale);
//			
//		Vector3 scaleVector = new Vector3 (scale, scale, 0);
//		transform.localScale = scaleVector;

	}

//	void OnTriggerEnter(Collider other) {
//		relative_y_speed = 0f;
//	}
//
//	void OnTriggerExit(Collider other) {
//		relative_y_speed = 1.5f;
//	}

}

