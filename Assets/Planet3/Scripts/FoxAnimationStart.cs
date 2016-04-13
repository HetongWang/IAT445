using UnityEngine;
using System.Collections;

public class FoxAnimationStart : MonoBehaviour {
	private Animator anim;
	public GameObject o;
	public AudioSource part1;
	public AudioSource part2;
	// Use this for initialization
	void Start () {
		anim = o.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ActionPart1(){
		part1.Play ();
	}

	public void ActionFox(){
		anim.SetBool ("foxLookBack", true);

	}

	public void ActionPart2(){
		part2.Play ();
	
	}
}
