using UnityEngine;
using System.Collections;

public class RPG : MonoBehaviour {

    public GameObject ammunitionPrefab;

    private float fireForce = 2000f;
    private float reloadTime = 0.7f;
    private float reloadTimer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        reloadTimer += Time.deltaTime;
	}

    public void fire()
    {
        if (reloadTimer < reloadTime)
            return;
        Vector3 pos = transform.Find("Bullet").transform.position;
        Vector3 fireDirection = -transform.right;
        Quaternion rotation = Quaternion.FromToRotation(Vector3.forward, fireDirection);
        GameObject o = Instantiate(ammunitionPrefab, pos, rotation) as GameObject;
        o.GetComponent<Rigidbody>().AddForce(fireDirection * fireForce);
        reloadTimer = 0;

        GetComponent<AudioSource>().Play();
    }
}
