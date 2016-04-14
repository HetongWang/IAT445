using UnityEngine;
using System.Collections;

public class audioLast : MonoBehaviour {

	public AudioSource part3;
	public AudioSource part4;
    public GameObject maincamera;
    public GameObject audioFadeOut;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Action3(){
		part3.Play ();
	}

	public void Action4(){
		part4.Play ();
	}

    void end()
    {
		Debug.Log ("end");
        StartCoroutine(ending());
    }
    IEnumerator ending()
    {
		Debug.Log ("ending");
        maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().FadeOut(true);
        audioFadeOut.GetComponent<AudioFadeOutGO>().FadeOut();

        float delay = maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().m_FadeDuration;
        yield return new WaitForSeconds(delay + 1.5f);
        Application.LoadLevel(5);
    }


}
