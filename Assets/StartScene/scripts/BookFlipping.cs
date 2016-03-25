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

    private void Awake() {
        anim = GetComponent<Animator>();
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
            StartCoroutine(loadLevel());
        }

    IEnumerator loadLevel()
        {
            while (timer < 5f)
            {
                anim.speed = anim.speed * 1.1f;
                timer += Time.deltaTime;
                yield return new WaitForEndOfFrame();
            }
            Application.LoadLevel(1);
        }
}
}