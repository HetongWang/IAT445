using UnityEngine;
using System.Collections;

public class Trigger1 : MonoBehaviour {

    public GameObject titanGroup;
    private bool triggered = false;
    int time = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        time++;
        if (!triggered && time == 2)
        {
            titanGroup.GetComponent<TitanGroup>().riseUp();
            triggered = true;
        }
    }
}
