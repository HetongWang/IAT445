using UnityEngine;
using System.Collections;

public class Fade : MonoBehaviour {
	
    public GameObject maincamera;
	public Texture2D fadeOutTexture;
	public float fadeSpeed = 0.8f;

	private int drawDepth = -1000;
	private float alpha = 1.0f;
	private int fadeDir= -1;

	public GameObject o;
	private Animator anim;



	// Use this for initialization
	void Start () {
		anim = o.GetComponent<Animator>();
		StartCoroutine (fading());
		Debug.Log (o.name);
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnGUI(){
		alpha += fadeDir * fadeSpeed * Time.deltaTime;
		alpha = Mathf.Clamp01(alpha);
		GUI.color = new Color(GUI.color.r, GUI.color.g, GUI.color.b, alpha);
		GUI.depth = drawDepth;
		GUI.DrawTexture(new Rect(0,0,Screen.width, Screen.height),fadeOutTexture);
	}

	public float BeginFade (int direction){
		fadeDir = direction;
		return (fadeSpeed);
	}


	IEnumerator fading()
	{
		yield return new WaitForSeconds (30f);
        end();

		Debug.Log("begin to fade out");
		yield return new WaitForSeconds (2f);
		anim.SetBool ("start",true);
	}

    void end()
    {
        StartCoroutine(ending());
    }
    IEnumerator ending()
    {
        maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().FadeOut(true);

        float delay = maincamera.GetComponent<VRStandardAssets.Utils.VRCameraFade>().m_FadeDuration;
        yield return new WaitForSeconds(delay + 1.5f);
    }


}
