using UnityEngine;
using System.Collections;

public class BookOpen : MonoBehaviour {
	private Animator anim;
    public GameObject maincamera;
    public GameObject audioFadeOut;
	// Use this for initialization
	void Start () {
	anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	StartCoroutine (triggerFlip());
	}
	
	IEnumerator triggerFlip(){
		yield return new WaitForSeconds (15f);
		anim.SetBool("start",true);
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
        Application.LoadLevel(1);
    }


}
