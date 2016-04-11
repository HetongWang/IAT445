using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LeaveBoat : MonoBehaviour {
	private Animator animReference;
	private GameObject hitObj;
	private bool triggerFloor;


	Camera camera;
	private GameObject boat;
	// Use this for initialization
	void Start () {
		boat = GameObject.FindGameObjectWithTag ("boat");
		camera = GetComponent<Camera> ();
		triggerFloor = false;
		Debug.Log (triggerFloor);
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("hi");
		Debug.Log (other.transform.name);
		if (other.transform.name == "boat") {
			boat.transform.parent = null;
			triggerFloor = true;
		}

		Debug.Log (triggerFloor);
	}
}
