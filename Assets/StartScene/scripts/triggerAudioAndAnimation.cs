using UnityEngine;
using System.Collections;

public class triggerAudioAndAnimation : MonoBehaviour {
	AudioSource audio;
	private Animator anim;
	private bool trigger = false;


	private void Awake()
	{
		anim = GameObject.FindGameObjectWithTag("Book").GetComponent<Animator>();
	}

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		if (anim != null) {
			Debug.Log (anim.name);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (audio.time >= 13.0) {
			trigger = true;
			Debug.Log ("start bool");
		}
		if (trigger){
			anim.SetBool("start", true);
		}
			
		//Debug.Log(audio.time);
	}
}