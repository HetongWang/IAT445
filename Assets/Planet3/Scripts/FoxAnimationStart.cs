using UnityEngine;
using System.Collections;

public class FoxAnimationStart : MonoBehaviour {
	private Animator anim;
	public GameObject o;
	// Use this for initialization
	void Start () {
		anim = o.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ActionFox(){
		anim.SetBool ("foxLookBack", true);
	}
}
