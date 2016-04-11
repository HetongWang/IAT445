using UnityEngine;
using System.Collections;

public class GoUp : MonoBehaviour {
	private Animator anim;
	public GameObject o;
	private Animator anim2;
	public GameObject o2;
	private Animator anim3;

	// Use this for initialization
	void Start () {
		anim = o.GetComponent<Animator>();
		anim2 = o2.GetComponent<Animator>();
		anim3 = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void actionUp(){
		anim.SetBool ("up", true);
		anim2.SetBool("up",true);
		anim3.SetBool("roseFallReverse", true);
	}

}
