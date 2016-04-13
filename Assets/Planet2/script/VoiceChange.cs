using UnityEngine;
using System.Collections;

public class VoiceChange : MonoBehaviour {
	public AudioSource spaceVoice;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void spaceVoiceTrigger(){
		spaceVoice.Play();
	}
}
