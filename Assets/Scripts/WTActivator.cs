using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WTActivator : MonoBehaviour {

	bool active;
	public GameObject panel;
	public GameObject player;

	// Use this for initialization
	void Start () {
		panel = GameObject.Find("Panel");
		player = GameObject.Find("main_character");
		panel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("space")){
			active = !active;
			panel.SetActive(active);
			player.SetActive(!active);
		}
	}

	public void ActiveWTMenu(){
		active = !active;
		panel.SetActive(active);
		player.SetActive(!active);
	}
}
