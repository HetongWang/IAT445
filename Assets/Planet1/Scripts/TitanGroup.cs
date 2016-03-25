using UnityEngine;
using System.Collections;

public class TitanGroup : MonoBehaviour {

    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.speed = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void riseUp()
    {
        rising();
    }

    void rising()
    {
        Debug.Log("Rise Up");
        anim.speed = 1;
    }

    void risingDone()
    {
        anim.SetInteger("action", 1);
    }
}
