using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets.Characters.FirstPerson;

public class Titan : MonoBehaviour {

    [HideInInspector]
    static public float sealevel = 133.0f;
    public GameObject triggerFellow;
    public GameObject titanGroup;
    public GameObject maincamera;
    public GameObject audioFadeOut;

    public AudioSource ap1;
    public AudioSource ap2;
    public AudioSource ap3;

    private Animator anim;
    private Rigidbody rig;
    private GameObject player;
    // Use this for initialization

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
    }

    public void moveStart()
    {
        anim.SetInteger("action", 0);
    }

    public IEnumerator standUp()
    {
        player.transform.position = transform.Find("joint7").Find("board").position;
        yield return new WaitForSeconds(0.7f);
        anim.SetInteger("action", 3);
    }

    void action0Done()
    {
        anim.SetInteger("action", 1);
    }

    void action1Done()
    {
        anim.SetInteger("action", 2);
        transform.position = new Vector3(0.5f, 136.5f, 6.6f);
    }

    void action2Done()
    {
    }

    public void action3()
    {
        StartCoroutine(standUp());
        triggerFellow.SetActive(true);
    }

    void action3Done()
    {
        anim.SetInteger("action", 4);
        ap2.Play();
    }

    void action4Done()
    {
        Debug.Log("loading planet 2");
        transform.position = new Vector3(0.5f, 136.5f, 477f);
        titanGroup.GetComponent<Animator>().speed = 0;
        StartCoroutine(end());
    }

    void audio3Trigger()
    {
        ap3.Play();
    }

    IEnumerator end()
    {
        maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().FadeOut(true);
        audioFadeOut.GetComponent<AudioFadeOut>().FadeOut();

        float delay = maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().m_FadeDuration;
        yield return new WaitForSeconds(delay + 1.5f);
        Application.LoadLevel(2);
    }
}
