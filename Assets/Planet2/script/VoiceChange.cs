using UnityEngine;
using System.Collections;

public class VoiceChange : MonoBehaviour {
	public AudioSource spaceVoice;
    public GameObject maincamera;
    public GameObject audioFadeOut;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void spaceVoiceTrigger(){
		spaceVoice.Play();
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
        Application.LoadLevel(3);
    }

}
