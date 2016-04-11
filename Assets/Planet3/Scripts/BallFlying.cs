using UnityEngine;
using System.Collections;
using VRStandardAssets.Utils;

namespace VRStandardAssets.Utils
{

public class BallFlying : MonoBehaviour {
	
	[SerializeField] private VRInteractiveItem m_InteractiveItem;
	public bool trigger;
		private Animator anim;
		private GameObject player;

		private void Awake(){
			anim = GetComponent<Animator> ();
		}

		private void OnEnable(){
			m_InteractiveItem.OnOver += HandleOver;
			m_InteractiveItem.OnOut += HandleOut;
		}

		private void OnDisable(){
			m_InteractiveItem.OnOver -= HandleOver;
			m_InteractiveItem.OnOut -= HandleOut;
		}

		private void HandleOver(){
			anim.SetBool ("trigger", true);
		}

		private void HandleOut(){
				anim.SetBool ("trigger", false);
			}
}

}