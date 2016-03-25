using UnityEngine;
using System.Collections;

public class RPGAmmunition : MonoBehaviour {

    public GameObject explosion;

    private Rigidbody rig;
    private float lifeTime = 3f;
    private float lifeTimer = 0;
    private float flyForce = 30f;

	// Use this for initialization
	void Start () {
        Vector3 com = new Vector3(-30, 0, 0);
        rig = GetComponent<Rigidbody>();
        rig.centerOfMass = com;
	}
	
	// Update is called once per frame
	void Update () {
        flying();
        lifeTimer += Time.deltaTime;
	}

    void flying()
    {
        Vector3 direction = transform.forward;
        rig.AddForce(direction * flyForce);
        if (lifeTimer > lifeTime)
            explore();
    }

    void OnCollisionEnter(Collision col)
    {
        explore();
        if (col.gameObject.tag == "Enemy")
        {
            Destroy(col.gameObject);
        }
    }

    void explore()
    {
        Instantiate(explosion, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
