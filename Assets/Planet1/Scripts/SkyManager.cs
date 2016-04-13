using UnityEngine;
using System.Collections;

public class SkyManager : MonoBehaviour {

    Material skyMaterial;
	// Use this for initialization
	void Start () {
        StartCoroutine(dark());
        skyMaterial = RenderSettings.skybox;
        skyMaterial.SetFloat("_SkyBlend", 0);
	}
	
	// Update is called once per frame
	void Update () {
	}

    IEnumerator dark()
    {
        float duration = 25;
        float end = 1f;
        yield return new WaitForSeconds(70);

        float timer = 0;
        float fog = RenderSettings.fogDensity;
        while (skyMaterial.GetFloat("_SkyBlend") < end)
        {
            Debug.Log(timer / duration);
            float blend = skyMaterial.GetFloat("_SkyBlend") + end / duration * Time.deltaTime;
            skyMaterial.SetFloat("_SkyBlend", blend);

            RenderSettings.fogDensity = Mathf.Lerp(fog, 0, timer / duration);
            timer += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
    }
}
