using UnityEngine;
using System.Collections;

public class floorDownTopTrigger : MonoBehaviour {
	private Animator anim;
	public GameObject o;
	public GameObject o2;
	private Animator anim2;
	// Use this for initialization

	void Start () {
		anim = o.GetComponent<Animator>();
		anim2 = o2.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Action1(){
		Debug.Log ("mother");
		anim.SetBool ("floorDownTop", true);
		anim2.SetBool ("floorDownTop", true);
	}
}
