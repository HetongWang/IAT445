using UnityEngine;
using System.Collections;

public class floatSphere : MonoBehaviour {

    Animator anim;
    RangeAttribute startDelay = new RangeAttribute(0, 3);
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.speed = 0;
        StartCoroutine(randomFloat());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator randomFloat()
    {
        float delay = Random.RandomRange(startDelay.min, startDelay.max);
        yield return new WaitForSeconds(delay);
        anim.speed = 1;
    }
}
