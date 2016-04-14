using UnityEngine;
using System.Collections;

public class parent : MonoBehaviour {
	public AudioSource planet2Voice1;
	public AudioSource planet2Voice2;
	public AudioSource planet2Voice3;
	public AudioSource planet2Voice4;
    public GameObject maincamera;
    public GameObject audioFadeOut;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void trigger1(){
		planet2Voice1.Play();
	}

	void trigger2(){
		planet2Voice2.Play();
	}

	void trigger3(){
		planet2Voice3.Play();
	}

	void trigger4(){
		planet2Voice4.Play();
	}

    void end()
    {
        StartCoroutine(ending());
    }

    IEnumerator ending()
    {
        maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().FadeOut(true);
        audioFadeOut.GetComponent<AudioFadeOut>().FadeOut();

        float delay = maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().m_FadeDuration;
        yield return new WaitForSeconds(delay + 1.5f);
        Application.LoadLevel(4);
    }

}
