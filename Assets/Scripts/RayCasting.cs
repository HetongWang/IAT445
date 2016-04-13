using UnityEngine;
using System.Collections;

public class RayCasting : MonoBehaviour
{

    private Animator animReference;
    private GameObject hitObj;

    Camera camera;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = camera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;
        Debug.DrawRay(ray.origin, ray.direction * 50, Color.blue);

        if (Physics.Raycast(ray, out hit) == true)
        {
            if (hit.transform.name == "car")
            {
                hitObj = hit.transform.gameObject;
                animReference = hitObj.GetComponent<Animator>();
                animReference.SetBool("driving", true);
                //hitObj.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
            }
            else
            {
                if (this.hitObj != null)
                {
                    hitObj = hit.transform.gameObject;
                    animReference.SetBool("driving", false);
                    //hitObj.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
            if (hit.transform.name == "snowman2")
            {
                hitObj = hit.transform.gameObject;
                animReference = hitObj.GetComponent<Animator>();
                animReference.SetBool("sayhii", true);
                hitObj.GetComponent<AudioSource>().Play();
                //hitObj.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
            }
            else
            {
                if (this.hitObj != null)
                {
                    hitObj = hit.transform.gameObject;
                    //hitObj.GetComponent<AudioSource>().Stop();
                    animReference.SetBool("sayhii", false);
                    
                    //hitObj.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
            if (hit.transform.name == "san6")
            {
                hitObj = hit.transform.gameObject;
                animReference = hitObj.GetComponent<Animator>();
                animReference.SetBool("saning6", true);
                //hitObj.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
            }
            else
            {
                if (this.hitObj != null)
                {
                    hitObj = hit.transform.gameObject;
                    animReference.SetBool("saning6", false);
                    //hitObj.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
            if (hit.transform.name == "flight")
            {
                hitObj = hit.transform.gameObject;
                animReference = hitObj.GetComponent<Animator>();
                animReference.SetBool("playing", true);
                //hitObj.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
            }
            else
            {
                if (this.hitObj != null)
                {
                    hitObj = hit.transform.gameObject;
                    animReference.SetBool("playing", false);
                    //hitObj.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
            if (hit.transform.name == "clock")
            {
                hitObj = hit.transform.gameObject;
                animReference = hitObj.GetComponent<Animator>();
                animReference.SetBool("rotating", true);
                //hitObj.GetComponent<Renderer>().material.color = Color.yellow;
                Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
            }
            else
            {
                if (this.hitObj != null)
                {
                    hitObj = hit.transform.gameObject;
                    animReference.SetBool("rotating", false);
                    //hitObj.GetComponent<Renderer>().material.color = Color.blue;
                }
            }
        }
        else
        {
            Debug.Log("I'm looking at nothing!");
        }

    }
}