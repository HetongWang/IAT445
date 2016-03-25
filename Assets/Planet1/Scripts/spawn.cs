using UnityEngine;
using System.Collections;

public class spawn : MonoBehaviour {

    public GameObject creature;

    private RangeAttribute cdRange = new RangeAttribute(6, 13);
    private float cd;
    private float cdTimer = 0;
    private RangeAttribute range = new RangeAttribute(-20, 20);

	// Use this for initialization
	void Start () {
        cd = Random.Range(cdRange.min, cdRange.max);
	}
	
	// Update is called once per frame
	void Update () {
        cdTimer += Time.deltaTime;
        if (cdTimer > cd)
            respawn();
	}

    void respawn()
    {
        Vector3 pos = transform.position;
        pos.x += Random.Range(range.min, range.max);
        pos.y += creature.transform.position.y;
        pos.z += Random.Range(range.min, range.max);
        GameObject o = Instantiate(creature, pos, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
        cdTimer = 0;
        cd = Random.Range(cdRange.min, cdRange.max);
    }
}
