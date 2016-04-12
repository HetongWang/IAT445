using UnityEngine;
using System.Collections;

public class TitanFellow : MonoBehaviour {

    RangeAttribute delay = new RangeAttribute(0, 4);
    Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.speed = 0;
        StartCoroutine(animDelay());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator animDelay()
    {
        yield return new WaitForSeconds(Random.Range(delay.min, delay.max));
        anim.speed = 1;
    }
	
}
