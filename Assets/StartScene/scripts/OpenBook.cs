using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Examples
{
    public class OpenBook : MonoBehaviour
    {

        [SerializeField]
        private VRInteractiveItem m_InteractiveItem;

        public bool startChange;
        private Animator anim;
        private GameObject player;

        private void Awake()
        {
			anim = GameObject.FindGameObjectWithTag("Book").GetComponent<Animator>();
        }

        private void OnEnable()
        {
            m_InteractiveItem.OnOver += HandleOver;
            m_InteractiveItem.OnOut += HandleOut;
        }

        private void OnDisable()
        {
            m_InteractiveItem.OnOver -= HandleOver;
            m_InteractiveItem.OnOut -= HandleOut;
        }

        private void HandleOver()
        {
            Debug.Log("Show over state");
            anim.SetBool("startChange", true);
        }

        private void HandleOut()
        {
            Debug.Log("Show out state");
            anim.SetBool("startChange", false);
        }
    }
}