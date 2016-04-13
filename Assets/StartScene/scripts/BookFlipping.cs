using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
public class BookFlipping : MonoBehaviour {

    [SerializeField] private VRInteractiveItem m_InteractiveItem;

    public bool bookFlip;
    private Animator anim;
    private GameObject player;
        private float timer = 0;
        private bool triggered = false;

    private void Awake() {
        anim = GetComponent<Animator>();
		anim.speed = 0.5f;
    }

    private void OnEnable() {
        m_InteractiveItem.OnOver += HandleOver;
        m_InteractiveItem.OnOut += HandleOut;
    }

    private void OnDisable() {
        m_InteractiveItem.OnOver -= HandleOver;
        m_InteractiveItem.OnOut -= HandleOut;
    }

    private void HandleOver() {
        Debug.Log("Show over state");
        anim.SetBool("bookFlip", true);
    }

    private void HandleOut() {
        Debug.Log("Show out state");
			anim.SetBool("bookFlip", false);
    }

        void readytoload()
        {
            if (!triggered)
                StartCoroutine(loadLevel());
        }

    IEnumerator loadLevel()
        {
            triggered = true;
            while (timer < 5f)
            {
                Debug.Log(timer);
                anim.speed = anim.speed > 4 ? 4 : anim.speed * (1.0f + Time.deltaTime);
                timer += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            Application.LoadLevel(1);
        }
}
}