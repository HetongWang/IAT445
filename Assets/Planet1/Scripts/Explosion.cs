using UnityEngine;
using System.Collections;

public class Explosion : MonoBehaviour {

    private float lifeTime = 3f;
    private float lifeTimer = 0;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        lifeTimer += Time.deltaTime;
        if (lifeTimer > lifeTime)
            Destroy(gameObject);
	}

    void OnTriggerEnter(Collider col)
    {
        if (lifeTimer > 0.5f)
            return;
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }
}
