using UnityEngine;
using System.Collections;

public class audioLast : MonoBehaviour {
	public AudioSource part3;
	public AudioSource part4;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Action3(){
		part3.Play ();
	}

	public void Action4(){
		part4.Play ();
	}
}
