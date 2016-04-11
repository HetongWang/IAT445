using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	private Animator anim;
	public GameObject o;
	// Use this for initialization
	void Start () {
		anim = o.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void action2(){
		Debug.Log ("mother");
		anim.SetBool ("goToRose", true);
	}
}
