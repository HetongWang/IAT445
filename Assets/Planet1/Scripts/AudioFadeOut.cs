using UnityEngine;
using System.Collections;

public class AudioFadeOut : MonoBehaviour {

    public AudioSource ap;
    public float duration;
    float volume;

	// Use this for initialization
	void Start () {
        volume = ap.volume;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void FadeOut()
    {
        StartCoroutine(beginFadeOut());
    }

    IEnumerator beginFadeOut()
    {
        while (ap.volume > 0)
        {
            Debug.Log(ap.volume);
            ap.volume -= volume / duration * Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        if (ap.volume < 0)
            ap.volume = 0;
    }
}
