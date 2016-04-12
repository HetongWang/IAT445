using UnityEngine;
using System.Collections;

public class SeagullGroup : MonoBehaviour {

    float movespeed = 10;
	// Use this for initialization
	void Start () {
        StartCoroutine(move());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator move()
    {
        yield return new WaitForSeconds(15);
        while (transform.position.z < 1000)
        {
            Vector3 newpos = transform.position;
            newpos.z += movespeed * Time.deltaTime;
            transform.position = newpos;
            yield return new WaitForEndOfFrame();
        }
    }
}
