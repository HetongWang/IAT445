using UnityEngine;
using System.Collections;

public class parent : MonoBehaviour {
	public AudioSource planet2Voice1;
	public AudioSource planet2Voice2;
	public AudioSource planet2Voice3;
	public AudioSource planet2Voice4;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void trigger1(){
		planet2Voice1.Play();
	}

	void trigger2(){
		planet2Voice2.Play();
	}

	void trigger3(){
		planet2Voice3.Play();
	}

	void trigger4(){
		planet2Voice4.Play();
	}

}
