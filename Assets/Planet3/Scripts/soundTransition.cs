using UnityEngine;
using System.Collections;

public class soundTransition : MonoBehaviour {
	private AudioSource audio;
	private AudioSource audio2;
	public GameObject o;
	private AudioSource audio3;
	private GameObject o2;
	private bool trigger=false;
	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio2 = o.GetComponent<AudioSource>();
		o2 = GameObject.FindGameObjectWithTag ("waterAudio");
		audio3 = o2.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(trigger){
			fadeOut();
			fadeIn();
		}
	}

	public void soundToTransition(){
		audio.Play();
		audio.volume=0;
		trigger=true;
	}

	public void fadeIn(){
		
		if (audio.volume < 1){
			audio.volume += 1 * Time.deltaTime/10;
			print (audio.volume + "goingin");
		}

	}

	public void fadeOut(){
		audio2.volume -= 1 * Time.deltaTime/5;
		if (audio2.volume <=0){
			audio2.Stop();
		}
		audio3.volume -= 1 * Time.deltaTime/5;
		if (audio3.volume <=0){
			audio3.Stop();
		}

	}
}
