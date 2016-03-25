using UnityEngine;
using System.Collections;

public class TitanButton : MonoBehaviour
{
    public GameObject titan;
    private GameObject player;
    private bool pressed = false;
    private float triggerDistance = 5;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public bool press()
    {
        if (!pressed)
        {
            if (Vector3.Distance(player.transform.position, transform.position) < triggerDistance)
            {
                pressed = true;
                titan.GetComponent<Titan>().moveStart();
                Transform t = transform.FindChild("Text");
                t.gameObject.SetActive(false);
            }
        }

        return pressed;
    }
}
