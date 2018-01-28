using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProximityReaction : MonoBehaviour {

  GameObject button;
  Animator buttonAnim;

  // Use this for initialization
  void Start () {
    button = GameObject.Find("Button");
    buttonAnim = button.GetComponent<Animator>();
  }
  
  // Update is called once per frame
  void Update () {
    
  }

  void OnTriggerEnter(Collider other)
  {
      GetComponent<AudioSource>().Play();
      buttonAnim.SetBool("isOn", true);
  }

  void OnTriggerExit(Collider other)
  {
      buttonAnim.SetBool("isOn", false);
  }
}
