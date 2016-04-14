﻿using UnityEngine;
using System.Collections;

public class player : MonoBehaviour {

    public GameObject mainCamera;
    public GameObject titanNeedtoMove;
    private GameObject looked = null;
    private GameObject titan;

    public AudioSource ap1;

    private Animator anim;
    private bool onTitan = false;
    private float staringTime = 0;
    private float staringTriggerDelay = 2;
    private float triggerDistance = 3;

	// Use this for initialization
	void Start () {
        mainCamera = transform.Find("MainCamera").gameObject;
        anim = GetComponent<Animator>();
        StartCoroutine(startMove());
	}
	
	// Update is called once per frame
	void Update () {
        lookat();
        if (Input.GetButton("Fire"))
        {
            Debug.Log(looked.transform.name);
            if (looked.transform.name == "Titan" && onTitan == false)
            {
                Vector3 boardPos = looked.transform.Find("joint7").Find("board").position;
                if (Vector3.Distance(boardPos, transform.position) < triggerDistance)
                {
                    looked.GetComponent<Titan>().action3();
                    titan = looked;
                    onTitan = true;
                    transform.parent = titan.transform;
                }
            }

        }

        if (onTitan)
        {
            transform.localRotation = Quaternion.Euler(new Vector3(0, 90, 0));
            transform.position = titan.transform.Find("joint7").Find("board").position;
        }
    }

    IEnumerator startMove()
    {
        float speed = 1.5f;
        Vector3 target = transform.position;
        
        yield return new WaitForSeconds(3);
		ap1.Play();
        StartCoroutine(moveTitan());

        while (transform.position.z < -1.35f)
        {

            target.z += speed * Time.deltaTime;
            transform.position = target;
            yield return new WaitForEndOfFrame();
        }
    }

    IEnumerator moveTitan()
    {
        yield return new WaitForSeconds(3f);
        titanNeedtoMove.GetComponent<Titan>().moveStart();
    }

    void lookat()
    {
        RaycastHit hit;
        Ray ray = mainCamera.GetComponent<Camera>().ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit))
        {
            if (looked && hit.transform.gameObject.name == looked.transform.name)
            {
                staringTime += Time.deltaTime;
            }
            else
            {
                staringTime = 0;
            }
            looked = hit.transform.gameObject;
        }
        else
        {
            looked = gameObject;
        }
    }
}
