using UnityEngine;
using System.Collections;

public class LoadNewScene : MonoBehaviour {
    AsyncOperation asyn;
	// Use this for initialization
	void Start () {
        StartCoroutine(loading());
	}
	
	// Update is called once per frame
	void Update () {
        if (asyn != null && asyn.isDone)
        {
            asyn.allowSceneActivation = true;
        }
	}

    IEnumerator loading()
    {
        yield return new WaitForSeconds(45f);
        asyn = Application.LoadLevelAsync(3);
        yield return asyn;
    }
}
