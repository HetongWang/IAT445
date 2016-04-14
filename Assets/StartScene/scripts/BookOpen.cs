using UnityEngine;
using System.Collections;

public class BookOpen : MonoBehaviour {
	private Animator anim;
	// Use this for initialization
	void Start () {
	anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	StartCoroutine (triggerFlip());
	}
	
	IEnumerator triggerFlip(){
		yield return new WaitForSeconds (15f);
		anim.SetBool("start",true);
	}
}
