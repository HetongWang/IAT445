using UnityEngine;
using System.Collections;

public class smile : MonoBehaviour {

    public string targetName;

    private float minPlayerDistance = 8;
    private float speed = 3;
    private GameObject target;
    private Animator anim;
    private Coroutine moveCoroutine;
    private float jumpForce = 325;
    private bool moving = false;

	// Use this for initialization
	void Start ()
    {
        target = GameObject.FindGameObjectWithTag(targetName);
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        var lookPos = target.transform.position - transform.position;
        lookPos.y = 0;
        transform.rotation = Quaternion.LookRotation(lookPos);
        float dis = Vector3.Distance(target.transform.position, transform.position);
        if (dis > minPlayerDistance && !moving)
        {
            StartCoroutine(moveAction());
        }
	}

    IEnumerator moveAction()
    {
        moving = true;
        anim.SetBool("Move", true);
        yield return new WaitForSeconds(2.5f);
        anim.SetBool("Move", false);
        moving = false;
    }

    void startMove()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(0, jumpForce, 0));
        moveCoroutine = StartCoroutine(move());
    }
    
    void stopMove()
    {
        StopCoroutine(moveCoroutine);
    }

    IEnumerator move()
    {
        float step = speed * Time.deltaTime;
        while (true)
        {
            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, step);
            yield return new WaitForEndOfFrame();
        }
    }

}
