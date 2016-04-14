using UnityEngine;
using System.Collections;

public class AudioFadeIn : MonoBehaviour {

    public AudioSource ap;
    public float duration;
    float volume;

	// Use this for initialization
	void Start () {
        volume = ap.volume;
        ap.volume = 0;
        StartCoroutine(fadein());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator fadein()
    {
        while (ap.volume < volume)
        {
            ap.volume += volume / duration * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}
