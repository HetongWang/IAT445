using UnityEngine;
using System.Collections;

public class FloorMovement : MonoBehaviour {
	private Animator animReference3;
	private Animator animReference4;


	Camera camera;
	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera> ();
		Debug.Log("oh0");
		animReference3 = GameObject.Find ("floorLeft").GetComponent<Animator> ();
		animReference4 = GameObject.Find ("floorRight").GetComponent<Animator> ();
		if (animReference3 != null) {
			Debug.Log ("not null");
			animReference3.SetBool ("floorDown", false);
		}
		if (animReference4 != null) {
			Debug.Log ("not null");
			animReference4.SetBool ("floorDown", false);
		}
	}
	
	// Update is called once per frame
	void Update () {

			
		} 

	void OnTriggerEnter(Collider other)
	{
		Debug.Log (other.gameObject.transform.name);
		animReference3.SetBool ("floorDown", true);
		animReference4.SetBool ("floorDown", true);
	}

	}
	