﻿using UnityEngine;
using System.Collections;

public class Trigger : MonoBehaviour {

    public GameObject guide;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            guide.SetActive(true);
        }
    }

}
