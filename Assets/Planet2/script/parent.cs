using UnityEngine;
using System.Collections;

public class parent : MonoBehaviour {
	public GameObject o;
	public GameObject o2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void ChangeParent(){
		o2.transform.parent = o.transform;
	}
}
