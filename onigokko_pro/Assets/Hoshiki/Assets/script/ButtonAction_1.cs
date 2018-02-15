using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class ButtonAction_1 : MonoBehaviour 
{
	[SerializeField]
	Animator animator;

	static readonly int hashStatesyouji_close = Animator.StringToHash("syouji_close 0");

	// button event
	public void OnOK()
	{
		animator.Play (hashStatesyouji_close);
	}


}