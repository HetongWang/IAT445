using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {
    public bool driving;
    private Animator anim;
    private GameObject player;
	// Use this for initialization
	void Start () {
	
	}

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        int scrx = Screen.width / 2;
        int scry = Screen.height / 2;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //Ray ray = Camera.main.ScreenPointToRay(new Vector2(scrx, scry));
        //Check if something is where our mouse is
        anim = GetComponent<Animator>();
        if (Physics.Raycast(ray, out hit, 100))
            //Check if what we're hitting is the gameObject with a tag of "Food"
            if (hit.transform.gameObject.tag == ("car"))
            {
                anim.SetBool("driving", true);
                //driving = true;
            }
            else {
                anim.SetBool("driving", false);
                //driving = false;
            }
    }
}
