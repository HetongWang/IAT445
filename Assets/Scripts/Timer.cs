using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    private string currentTime;
    public Text timeText;
    float setTime = 30.0f;


	// Use this for initialization
	void Start () {
        timeText = GameObject.Find("timerUIText").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
	    if (setTime <= 0)
        {
            setTime = 0;
            timeText.text = "LALALA";
        }
        else
        {
            setTime -= Time.deltaTime;
            currentTime = string.Format("{0:0.0}", setTime);

            timeText.text = "Time Left: " + currentTime;
        }
	}
}
